using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _6MaxLayerBurgers_BlazorWebAssembly.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _6MaxLayerBurgers_BlazorWebAssembly.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViewAllBurgersController : ControllerBase
    {

        static List<Burger> burgerList = new List<Burger>();

        [HttpGet]
        //viewAllBurgers will display all the burgers
        public async Task<IActionResult> viewAllBurgers()
        {

            return Ok(burgerList);
        }

        [HttpGet("{burgerName}")]
        //viewABurger will display a single burger
        public async Task<IActionResult> viewABurger(String burgerName)
        {
            var burger = new Burger();

            if (burgerList.Exists(tempBurger => tempBurger.getBurgerName().Equals(burgerName)))
            {

                burger = burgerList.Find(tempBurger => tempBurger.getBurgerName().Equals(burgerName));

            }
            else
            {
                return NotFound("The burger " + burgerName + " was not found !!!");
            }



            return Ok(burger);

        }

        [HttpPost]
        public async Task<IActionResult> addABurger(Burger b1)
        {
            burgerList.Add(b1);

            return Ok(burgerList);
        }

    }

}


