  using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace C_Assignment1.Controllers
{
    public class AddTenController : ApiController
    {
       // <summary> this controller adds ten to the input ID and returns the sum
       // tested with integers 21, 0, and -9
       //GET api/AddTen
       public int Get(int id) 
        {
        int sum = id + 10;
        return sum;
        }
     
    }
}
