using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Calculator_WebAppApi.Controllers
{
    [Route("api/[controller]/[action]")]
    public class MathController : Controller
    {
        [HttpPut]
        public string Put(string text)
        {
            return text.ToUpper();
        }
        [HttpGet]

        public double Add(int left, int right)
        {
            return left + right;
        }
        [HttpGet]

        public double Substraction(double left, double right)
        {
            return left - right;
        }
        [HttpGet]

        public double Multiplication(double left, double right)
        {
            return left * right;
        }

        [HttpGet]
        public double Division(double left, double right)
        {
            if (right != 0)
            {
                return left / right;
            }
            else
            {
                throw new DivideByZeroException();

            }
            //// GET: api/values
            //[HttpGet]
            //public IEnumerable<string> Get()
            //{
            //    return new string[] { "value1", "value2" };
            //}

            //// GET api/values/5
            //[HttpGet("{id}")]
            //public string Get(int id)
            //{
            //    return "value";
            //}

            //// POST api/values
            //[HttpPost]
            //public void Post([FromBody] string value)
            //{
            //}

            //// PUT api/values/5
            //[HttpPut("{id}")]
            //public void Put(int id, [FromBody] string value)
            //{
            //}

            //// DELETE api/values/5
            //[HttpDelete("{id}")]
            //public void Delete(int id)
            //{
            //}
        }

       
    }
}
