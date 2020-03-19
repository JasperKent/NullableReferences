using System;

namespace NullableReferences
{
    class Program
    {
        static void Main()
        {
            MotorCar car = new MotorCar(new Person ("Jenson"), 
                                        new Engine { Capacity = 1600 });

            Console.WriteLine(car);
        }
    }
}
