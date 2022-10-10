
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
            canSwing = true;
            groupOrClass = "Reptilia";
            canFly = false;
            fertilization = "internal";
        }
        public int numSpecies  { get; set; }
        public string reproduction { get; set; }  
        public bool isDangerous { get; set; } 
        public bool canRegenerate { get; set; }    

    }
}
