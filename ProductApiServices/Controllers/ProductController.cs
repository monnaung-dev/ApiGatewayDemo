using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductApiServices.Models;

namespace ProductApiServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<Product> list = new List<Product>();
            Product product1 = new Product();
            product1.id = 1;
            product1.name = "Hp laptop";

            Product product2 = new Product();
            product2.id = 2;
            product2.name = "Dell laptop";

            list.Add(product1);
            list.Add(product2);
            return Ok(new {data=list });
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            Product product = new Product();

            if(id == 1)
            {
                product.id = 1;
                product.name = "Hp laptop";
            }else if(id == 2)
            {
                product.id = 2;
                product.name = "Dell laptop";
            }
            else
            {
                product.id = 0;
                product.name = "Nothing in stock";
            }
           

            return Ok(new { data = product });
        }
    }
}
