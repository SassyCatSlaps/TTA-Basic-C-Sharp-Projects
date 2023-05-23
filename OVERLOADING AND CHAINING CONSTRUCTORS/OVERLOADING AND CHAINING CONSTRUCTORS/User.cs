using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OVERLOADING_AND_CHAINING_CONSTRUCTORS
{
    // Below is an example of a User class with overloaded constructors:
    public class User
    {
        /* By overloading the constructors you are able to allow different ways to instantiate the object. 
        As you can see in the example above, you can instantiate a User with the username and location provided or with only the username 
        provided and the location will be given a default value (“Online”).  */

        //public string username;
        //public string location;

        //public User (string username)
        //{
        //    this.username = username;
        //    location = "Online";
        //}

        //public User(string username, string location)
        //{
        //    this.username = username;
        //    this.location = location;
        //}

        /* However, overloading constructors in this way leads to duplicate code (in both constructors we are assigning values to the 
        username and location properties). Chaining constructors allows you to overload operators without duplicating code. 
        Let’s see how this works: */

        //public string username;
        //public string location;

        //public User(string username) : this(username, "Online")
        //{
        //}

        //public User(string username, string location)
        //{
        //    this.username = username;
        //    this.location = location;
        //}
        /* The :this( ) keyword is used to reference another constructor. 
        So in the above example, the first constructor takes one parameter (the username) and then references the 
        constructor that takes two parameters (the username and location) 
        and passes the parameter it received as well as the default value for the second parameter. */

        /* Constructor chaining can be done with more than two constructors. 
        Let’s say you wanted to provide default values for if a User was created with no 
        username or location provided. The code would look something like this: */

        public string username;
        public string location;

        public User() : this("User 1")
        {
        }

        public User(string username) : this(username, "Online")
        {
        }

        public User(string username, string location)
        {
            this.username = username;
            this.location = location;
        }
        /* Above, the first constructor (which takes no parameters) calls the constructor that accepts 
        one parameter with the default value (“User 1”) which then calls the third constructor that 
        accepts two parameters and passes the default values (“User 1” and “Online”) to the object.  */
    }
}