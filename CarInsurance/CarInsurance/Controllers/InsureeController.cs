using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;


/* Complete these actions:
1. In the InsureeController, add logic to calculate a quote based on these guidelines: 
a. Start with a base of $50 / month.
b. If the user is 18 or under, add $100 to the monthly total.
c. If the user is from 19 to 25, add $50 to the monthly total.
d. If the user is 26 or older, add $25 to the monthly total. Double check your code to ensure all ages are covered.
e. If the car's year is before 2000, add $25 to the monthly total.
f. If the car's year is after 2015, add $25 to the monthly total.
g. If the car's Make is a Porsche, add $25 to the price.
h. If the car's Make is a Porsche and its model is a 911 Carrera, add an additional $25 to the price. (Meaning, this specific car will add a total of $50 to the price.)
i. Add $10 to the monthly total for every speeding ticket the user has.
j. If the user has ever had a DUI, add 25% to the total.
k. If it's full coverage, add 50% to the total.
2. Modify the Create View so that the user does not see the “Quote” input field.
3. a. Add an Admin View for a site administrator to the Insuree Views. 
b. This page must show all quotes issued, along with the user's first name, last name, and email address. */

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        // 3. c. Had to add a new action method that is responsible for rendering the admin view in the browser so I could see if my "Admin.cshtml" additions were ok -- had to add some new route mapping to "RouteConfig.cs" to make this work
        // Could also add '[Route]' attribute to 'Admin' action method for this step
        public ActionResult Admin()
        {
            var allInsurees = db.Insurees.ToList();
            return View(allInsurees);
        }

        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {  
                // 1. In the InsureeController, add logic to calculate a quote based on these guidelines: 
                // a. Start with a base of $50 / month
                decimal userMonthlyBillTotal = 50;

                // Before step b. I made my code easier to read by calculating the user's age based on their date of birth ("DateOfBirth")
                DateTime currentDate = DateTime.Now;
                int userAge = currentDate.Year - insuree.DateOfBirth.Year;
                // This code block will adjust the "userAge" based on the actual current day/month
                if (insuree.DateOfBirth > currentDate.AddYears(-userAge))
                {
                    userAge -- ;
                }

                // b. If the user is 18 or under, add $100 to the monthly total
                if (userAge <= 18)
                {
                    userMonthlyBillTotal += 100;
                }

                // c. If the user is from 19 to 25, add $50 to the monthly total
                else if (userAge >= 19 && userAge <= 25)
                {
                    userMonthlyBillTotal += 50;
                }

                // d. If the user is 26 or older, add $25 to the monthly total. Double check your code to ensure all ages are covered
                else if (userAge >= 26)
                {
                    userMonthlyBillTotal += 25;
                }

                // e. If the car's year is before 2000, add $25 to the monthly total
                if (insuree.CarYear < 2000)
                {
                    userMonthlyBillTotal += 25;
                }

                // f. If the car's year is after 2015, add $25 to the monthly total
                if (insuree.CarYear > 2015)
                {
                    userMonthlyBillTotal += 25;
                }

                // g. If the car's Make is a Porsche, add $25 to the price
                if (insuree.CarMake == "Porsche")
                {
                    userMonthlyBillTotal += 25;

                    // h. If car's Make is a Porsche & its model is a 911 Carrera, add an additional $25 to price (i.e, this specific car will add a total of $50 to price) -- Nested block based on the elaboration in parenthese on this instuction
                    if (insuree.CarModel == "911 Carrera")
                    {
                        userMonthlyBillTotal += 25;
                    }
                }

                // i. Add $10 to the monthly total for every speeding ticket the user has
                userMonthlyBillTotal += 10 * insuree.SpeedingTickets;

                // j. If the user has ever had a DUI, add 25% to the total  --  DUI is a 'bool' so you don't need to do "(insuree.DUI > 0)" because it just checks if the user checked the box  --  used a floating-point number to represent the percentage
                if (insuree.DUI)
                {
                    userMonthlyBillTotal *= 1.25m; 
                }

                // k. If it's full coverage, add 50% to the total -- --  This is also 'bool' so you don't need to do "(insuree.CoverageType == "Full")" because it just checks if the user checked the box
                if (insuree.CoverageType)
                {
                    userMonthlyBillTotal *= 1.5m;
                }

                // SEE "Create.cshtml" FOR STEP 2: Modify the Create View so that the user does not see the “Quote” input field"
                // SEE "Admin.cshtml" FOR STEP 3: Add an Admin View for a site administrator to the Insuree Views. This page must show all quotes issued, along with the user's first name, last name, and email address

                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {

                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
