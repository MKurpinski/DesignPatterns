using System;
using DesignPatterns.AutoResolveFactory.Factory;
using DesignPatterns.AutoResolveFactory.FoodFactoryResolver;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.AutoResolveFactory.Controllers
{
    [Route("api/[controller]")]
    public class FoodController : Controller
    {
        private readonly IFoodFactory _foodFactory;
        private readonly IFoodFactoryResolver _foodFactoryResolver;

        public FoodController(IFoodFactory foodFactory, IFoodFactoryResolver foodFactoryResolver)
        {
            _foodFactory = foodFactory;
            _foodFactoryResolver = foodFactoryResolver;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_foodFactory.GetFood());
        }

        [HttpGet]
        [Route("{type}")]
        public IActionResult GetWithResolver(string type)
        {
            if (!Enum.TryParse(type, out FoodType enumType))
            {
                return BadRequest();
            }
            var factory = _foodFactoryResolver.Resolve(enumType);
            return Ok(factory.GetFood());
        }
    }
}
