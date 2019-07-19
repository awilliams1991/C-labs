using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Vehicle
    {
        /*
         * 2. Vehicle
        a. make – string
        b. model – string
        c. year – int
        d. weight – float
         * */


        //fields
        private string _make;
        private string _model;
        private int _year;
        private float _weight;

        //properties
        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }//end public make

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }//end public string

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }//end public year

        public float Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }//end public weight


        //ctors

        public Vehicle(string make, string model, int year, float weight)
        {
            Make = make;
            Model = model;
            Year = year;
            Weight = weight;
        }//end FQCTOR

        public Vehicle() { }//end generic Vehicle.


        //methods

        public override string ToString()
        {
            return string.Format("{0} {1} {2}, weighing {3} tons.",
                Year, 
                Make, 
                Model, 
                Weight);
        }
    }//end class Vehicle
}//end namespace
