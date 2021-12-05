using _6MaxLayerBurgers_BlazorWebAssembly.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _6MaxLayerBurgers_BlazorWebAssembly.Client.Services
{
    public interface IBurgerService
    {
        Task<List<Burger>> GetBurgers();
        Task<Burger> GetABurger(String burgerName);

    }
}
