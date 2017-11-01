using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatters.FactoryMethod.Factory;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatters.FactoryMethod.Controllers
{
    [Route("api/[controller]")]
    public class FoodController : Controller
    {
        private readonly IFoodFactory _foodFactory;

        public FoodController(IFoodFactory foodFactory)
        {
            _foodFactory = foodFactory;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_foodFactory.GetFood());
        }
    }
}
