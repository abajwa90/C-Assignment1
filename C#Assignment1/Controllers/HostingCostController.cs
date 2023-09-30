using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace C_Assignment1.Controllers
{
    public class HostingCostController : ApiController
    {
        //This controller outputs the total cost of a web hosting service per fortnight + taxes 
        // I was unable to get the right syntax and output for this problem, but I wanted to add the tax to the total nights and ouput as a string
        public string Get(string id)
        {
            int fortnight = 14;
            decimal fortnightCost = 5.50;
            decimal fortnightSubtotal = fortnight * fortnightCost;
            return fortnightSubtotal.ToString("1 fortnight at" + " " + fortnightCost + "/FN" + "= $5.50 CAD");
            

        }
    }
}
