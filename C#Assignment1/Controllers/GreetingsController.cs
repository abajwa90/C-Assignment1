using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Web.Http;

namespace C_Assignment1.Controllers
{
    public class GreetingsController : ApiController
    {
        //<summary> This controller outputs a greeting to an integer representing the number of people
        //tested with integers 3, 6 and 0
        //GET api/Greetings
        public string Get(string id)
        {
            int num = 3;
            string greeting = "Greetings to" + " " + num + " " + "people!";
            return greeting;
        }
        
    }
}