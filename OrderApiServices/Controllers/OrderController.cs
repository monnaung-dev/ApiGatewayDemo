using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrderApiServices.Models;

namespace OrderApiServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
      
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            
            Order order = new Order();
            if (id == 1)
            {
                order.serial = 001;
                order.productName = "Hp laptop";
                order.price = "$2000";
            }
            else
            {
                order.productName = "Not in stock";
            }
            
            return Ok(new { data = order });
        }

    }
}
