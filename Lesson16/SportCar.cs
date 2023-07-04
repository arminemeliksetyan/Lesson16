using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16
{
    internal class SportCar:Car
    {
        public bool isSportCar;
        public SportCar(string model, string marka, float engine, bool isSportCar):base(model, marka, engine) 
        {
            this.isSportCar = isSportCar;
        }

        public override void Print()
        {
            if (isSportCar is true) 
            {
                Console.WriteLine(" Wow ");
            }
            else
            {
                Console.WriteLine(" Ups ");
            }
            base.Print();
            Console.WriteLine(" Yes It's cute but it's realy fast and dangerous for life");
        }

        public override void Drive(Car car)
        {
            base.Drive(car);
            Console.WriteLine(" but faster than you drive ever. ");
        }
    }
}
