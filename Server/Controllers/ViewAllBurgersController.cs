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


        static Filling f1 = new Filling { layer1 = "Bun", layer2 = "Cheese", layer3 = "Egg", layer4 = "Tomatoes", layer5 = "Onions", layer6 = "Bun" };

        /*
        static Burger b1 = new Burger("CheeseBurger", f1, "Raji");
        static Burger b2 = new Burger("CheeseBurger", f1, "Raji");*/


        List<Burger> burgerList = new List<Burger>() { new Burger {burgerName="CheeseBurger", filling = f1, authourName = "Raji" } };

        

        //viewAllBurgers will display all the burgers
        public async Task<IActionResult> viewAllBurgers()
        {

            return Ok(burgerList);
        }

    }

}
