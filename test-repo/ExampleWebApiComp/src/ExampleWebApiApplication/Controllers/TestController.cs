﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ExampleWebApiApplication.Controllers
{
    public class TestController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok("test ok");
        }
    }
}
