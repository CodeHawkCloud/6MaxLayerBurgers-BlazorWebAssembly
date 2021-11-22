using System;
using System.Collections.Generic;
using System.Text;

namespace _6MaxLayerBurgers_BlazorWebAssembly.Shared
{
    public class Filling
    {
        public String layer1 { get; set; }
        public String layer2 { get; set; }
        public String layer3 { get; set; }
        public String layer4 { get; set; }
        public String layer5 { get; set; }
        public String layer6 { get; set; }

        public Filling()
        {

        }
        //overloaded constructor
        public Filling(String l2, String l3, String l4, String l5)
        {
            layer1 = "Bun";
            layer2 = l2;
            layer3 = l3;
            layer4 = l4;
            layer5 = l5;
            layer6 = "Bun";
        }

        //getters
        public String getLayer1()
        {
            return layer1;
        }
        public String getLayer2()
        {
            return layer2;
        }
        public String getLayer3()
        {
            return layer3;
        }
        public String getLayer4()
        {
            return layer4;
        }
        public String getLayer5()
        {
            return layer5;
        }
        public String getLayer6()
        {
            return layer6;
        }
    }
}
