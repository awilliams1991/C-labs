using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Trucks : Vehicle
    {
        public float LoadCapacity { get; set; }

        public Trucks(string make, string model, int year, float weight, float loadCapacity)
            :base(make, model, year, weight)
        {
            LoadCapacity = loadCapacity;
        }//end FQCTOR

        public Trucks() { }//end Generic CTOR

        public override string ToString()
        {
            return base.ToString() + " with a " + LoadCapacity + "ton load capacity\n"; 
        }//end override

    }//end class
}//end namespace
