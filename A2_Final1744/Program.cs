using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_Final1744
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            Boolean flag = true;
            while (flag)
            {
                Console.WriteLine("\n=========================\n");
                Console.WriteLine("1. Get Circle Radius");
                Console.WriteLine("2. Change Circle Radius");
                Console.WriteLine("3. Get Circle Circumference");
                Console.WriteLine("4. Get Circle Area");
                Console.WriteLine("5. Exit");
                Console.WriteLine("\n=========================\n");

                int num = Convert.ToInt16(Console.ReadLine());


                switch (num)
                {
                    case 1:
                        Console.WriteLine(circle.GetRadius().ToString());
                        break;
                    case 2:
                        Console.Write("Please Enter New Circle Radius :");
                        int radius = Convert.ToInt16(Console.ReadLine());
                        circle.SetRadius(radius);
                        break;
                    case 3:
                        Console.WriteLine(circle.GetCircumference().ToString());
                        break;
                    case 4:
                        Console.WriteLine(circle.GetArea().ToString());
                        break;
                    case 5:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Enter other value");
                        break;
                }

            }
        }
    }
}
