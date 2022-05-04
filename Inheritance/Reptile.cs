using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public bool IsColdBlooded { get; set; }

        public bool HasScales { get; set; }

        public string Environmet { get; set; }

        public string Defense { get; set; }

        public Reptile()
        {
        
        }

        public Reptile(string name, int age, int legs, bool hasBackbone, bool isColdBlooded, bool hasScales, string environmet, string defense)
        { 
            Name = name;
            Age = age;
            Legs = legs;
            HasBackbone = hasBackbone;
            IsColdBlooded = isColdBlooded;
            HasScales = hasScales;
            Environmet = environmet;
            Defense = defense;
        
        
        
        
        
        
        }

    }
}
