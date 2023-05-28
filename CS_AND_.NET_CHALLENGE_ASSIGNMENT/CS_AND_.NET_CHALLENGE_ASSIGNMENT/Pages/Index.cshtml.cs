using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Create a new ASP.NET Core web application project
// Design a simple ASP.NET Core web app that displays the actual server time in the browser

namespace CS_AND_.NET_CHALLENGE_ASSIGNMENT.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            // Code below will display the actual server time in the browser
            ViewData["ServerTime"] = DateTime.Now.ToString();
        }
    }
}
