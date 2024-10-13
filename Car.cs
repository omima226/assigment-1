using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment_1
{
    internal class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int YearOfCar { get; set; }
        public int Mileage { get; set; }

        public void Drive(int distance)
        {
            if (distance <= 0)
            {
                throw new ArgumentException("distance should be positive please try again");
            }
            Mileage += distance;
        }
        private int age;
        public int Age {
            get { return DateTime.Now.Year - YearOfCar; }



        }
    }
}

