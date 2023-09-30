using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace C_Assignment1.Controllers
{
    public class MathOperationsController : ApiController
    {
        //<summary> This controller has an input {id} and applies four mathematical operations to it
        //GET/api/MathOperations
        //tested with integers 5 --> product = 24, 3 --> product = 14, 10 --> product = 49

        public int Get(int id)
        {
            int product = id - 1 + 4 * id / 1;
            return product;
        }
    }
}
