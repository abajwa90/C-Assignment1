using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace C_Assignment1.Controllers
{
   
    public class SquareController : ApiController
    {
        // <summary> this controller gets the square of input ID and returns the product
        // tested with integers 2, -2, and 10
        //GET api/Square
        public int Get(int id)
        {
            int product = id * id;
            return product;

        }

    }
}
