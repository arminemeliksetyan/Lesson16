namespace Lesson16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Mercedes", "E 300", 3.5f);
            Car car2 = new Car("Bmw", "m 90", 3.2f);
            Car car3 = new SportCar("Doche", "Challanger", 4.5f, true);
            Car car4 = new SportCar("Ferrary", "250 gto", 6.0f, true);

            car1.Print();
            car1.Drive(car1);
            car2.Print();
            car2.Drive(car2);
            car3.Print();
            car3.Drive(car3);
            car4.Print();
            car4.Drive(car4);

           
        }
    }
}