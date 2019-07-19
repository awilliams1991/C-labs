using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class MotorHome : Vehicle
    {
        public float NumberOfBeds { get; set; }

        public MotorHome(string make, string model, int year, float weight, float numberOfBeds)
            :base (make, model, year, weight)
        {
            NumberOfBeds = numberOfBeds;
        }//end FQCTOR

        public MotorHome() { }//generic ctor
    }//end class
}//end namespace
