using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            canSwing = false;
            groupOrClass = "neornithes";
            canFly = true;
            fertilization = "internal";
           
        }
        public string beakShape { get; set; }
        public string nesting { get; set; }
        public int numSpecies { get; set; }    
        public bool migration { get; set; }

        
        


    }
}
