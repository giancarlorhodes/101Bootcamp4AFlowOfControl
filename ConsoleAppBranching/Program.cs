using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBranching
{
    class Program
    {
        static void Main(string[] args)
        {
            // driving a car to a 4 way stop sign


            string _direction = "right";

            if (_direction == "straight")
            {
                Console.WriteLine("car is going straight");
            }
            else if (_direction == "left")
            {
                Console.WriteLine("car is going left");
            }
            else if (_direction == "right")
            {
                Console.WriteLine("car is going right");
            }
            else {
                Console.WriteLine("not sure where car went");
            }


            Console.ReadKey();
        }
    }
}
