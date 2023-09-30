using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Web.Http;

namespace C_Assignment1.Controllers
{
    public class HelloWorldController : ApiController
    {
        // <summary> this controller outputs the greeting "Hello World" with an HTTP request
        // tested with string "Hello World"
        //POST api/HelloWorld
        //tested in Command Prompt with following command: 
        //C:\Users\Ameesa>curl -d "" http://localhost:56259/api/HelloWorld
            //"Hello World!"
            //C:\Users\Ameesa>

        public string Post()
        {
            return "Hello World!";
        }
    }
}
