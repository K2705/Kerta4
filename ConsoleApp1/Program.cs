using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Speed = 300;
            Console.WriteLine(car);
        }

        class Car
        {
            private readonly int MaxSpeed = 200;
            private int speed;
            public int Speed
            {
                get
                {
                    return speed;
                }
                set
                {
                    if (value > MaxSpeed)
                    {
                        speed = MaxSpeed;
                    }
                    else
                    {
                        speed = value;
                    }
                }
            }

            public override String ToString()
            {
                return Speed.ToString();
            }
        }
    }
}
