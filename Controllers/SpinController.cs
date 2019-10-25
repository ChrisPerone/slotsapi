using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SlotsApi.Data;
using SlotsApi.Models;
using Amazon.DynamoDBv2;

namespace SlotsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpinController : ControllerBase
    {
        private readonly SlotsApiContext _context;
        private readonly IAmazonDynamoDB _dynamoDB;

        public SpinController(IAmazonDynamoDB dynamoDB) {
            // _context = context;
            _dynamoDB = dynamoDB;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var models = _context.SlotModel.ToList();
            var titles = new List<string>();

            foreach(SlotModel model in models)
            {
                titles.Add(model.Title);
            }
            return new string[] { titles.ToString() };
            //Use model to generate spin result here
            // return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            var model = _context.SlotModel.FirstOrDefault(m => m.Id == id);
            if (model == null) {
                return NotFound();
            }

            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
