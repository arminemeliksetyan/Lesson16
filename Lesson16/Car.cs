using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16
{
    internal class Car
    {
        public string model;
        protected string marka;
        protected float engine;
        public Car(string model, string marka, float engine)
        {
            this.model = model;
            this.marka = marka;
            this.engine = engine;
        }

        public virtual void Print()
        {
            Console.WriteLine("\n It's cute car. ---- " + model + " " + marka);
        }

        public virtual void Drive(Car car) 
        {
            Console.WriteLine(" Engine ready to drive. ");
        }
    }
}
