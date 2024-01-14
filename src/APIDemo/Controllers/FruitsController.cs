using Microsoft.AspNetCore.Mvc;
using APIDemo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FruitsController : ControllerBase
    {
        private static readonly Fruit[] fruits = new Fruit[]
        {
            new Fruit("Apple","Red",Freshness.Rotten,0.5,1.75),
            new Fruit("Banana","Yellow",Freshness.Fresh,0.9,1.50),
            new Fruit("Orange","Orange",Freshness.Fresh,0.7,0.89)
        };

        [HttpGet]
        public async Task<IActionResult> GetAll() 
        {
            return Ok(fruits);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] Guid id)
        {
            Fruit result = null;

            foreach(var fruit in fruits)
            {
                if(fruit.Id == id)
                {
                    result = fruit;
                }
            }

            if(result is null)
                return NotFound();

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
           // mocking deletion of a specific fruit
            var newTempFruitData = fruits.Where(f => f.Id != id).ToArray();  

            if (fruits.Length > newTempFruitData.Length)
            {
                //return Ok(newTempFruitData); //Use this for debugging purposes only.
                return NoContent();
            }

            
            return NotFound();

        }
    }
}
