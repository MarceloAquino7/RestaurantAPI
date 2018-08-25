using Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;

namespace RestaurantAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MealController : ControllerBase
    {
        // GET api/meal/morning,1,2,3
        [HttpGet("{input}")]
        public ActionResult<string> Get(string input)
        {
            if (!string.IsNullOrEmpty(input))
                return MealBLL.ProcessRequest(input);

            return new HttpResponseMessage(HttpStatusCode.BadRequest).ToString();
        }
    }
}
