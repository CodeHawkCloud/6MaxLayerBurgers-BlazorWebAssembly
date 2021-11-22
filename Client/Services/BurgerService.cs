using _6MaxLayerBurgers_BlazorWebAssembly.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace _6MaxLayerBurgers_BlazorWebAssembly.Client.Services
{
    public class BurgerService : IBurgerService
    {

        //readonly httpClient variable
        private readonly HttpClient _httpClient;

        //constructor
        public BurgerService(HttpClient httpClient)
        {

            _httpClient = httpClient;

        }
        public async Task<List<Burger>> GetBurgers()
        {
            return await _httpClient.GetFromJsonAsync<List<Burger>>("api/ViewAllBurgers");
        }
    }
}
