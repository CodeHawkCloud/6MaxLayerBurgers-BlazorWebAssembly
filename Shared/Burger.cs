using System;
using System.Collections.Generic;
using System.Text;

namespace _6MaxLayerBurgers_BlazorWebAssembly.Shared
{
    public class Burger
    {
        //private fields
        public String burgerName { get; set; }
        public Filling filling { get; set; }
        public String authourName { get; set; }

        public Burger()
        {

            this.burgerName = "";

        }

        //overloaded constructor
        public Burger(String burgerName, Filling filling, String authourName)
        {
            this.burgerName = burgerName;
            this.filling = filling;
            this.authourName = authourName;

        }

        //getters
        public String getBurgerName()
        {
            return burgerName;
        }

        public Filling getFilling()
        {
            return filling;
        }

        public String getAuthourName()
        {
            return authourName;
        }

    }
}
