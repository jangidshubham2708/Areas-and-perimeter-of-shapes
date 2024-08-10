using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas_and_perimeter_of_shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer;
            float area;
            float perimeter;

            Console.WriteLine("Here,this is area and perimeter calculator of given varoius shapes");
            Console.WriteLine("For Reactangle please enter : rectangle");
            Console.WriteLine("For Square please enter :square");
            Console.WriteLine("For Triangle please enter :triangle");
            Console.WriteLine("For Circle please enter :circle");
            Console.Write("Shape = ");
            answer = Console.ReadLine().ToLower();

            switch (answer)
            {
                case "rectangle":
                    {
                        Console.WriteLine("Enter the height:");
                        float height = float.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the width:");
                        float width = float.Parse(Console.ReadLine());

                        area = height * width;
                        perimeter = 2 * (height + width);
                        break;
                    }

                case "square":
                    {
                        Console.WriteLine("Enter the side:");
                        float side = float.Parse(Console.ReadLine());

                        area = side * side;
                        perimeter = 4 * side;
                        break;
                    }


                case "triangle":
                    {
                        Console.WriteLine("Enter the height:");
                        float height = float.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the breadth:");
                        float breadth = float.Parse(Console.ReadLine());

                        area = (height * breadth)/2;
                        perimeter = 2*(height) + breadth;
                        break;
                    }

                case "circle":
                    {
                        Console.WriteLine("Enter the radius ");
                        float radius = float.Parse(Console.ReadLine());

                        area = (float)Math.PI * (radius*radius);
                        perimeter = (float)Math.PI * 2 * radius;
                        break;  
                    }
                default:
                    Console.WriteLine("Shape not recognized.");
                    return; // Exit the program or handle the default case accordingly
            }

            Console.WriteLine("The Area of given shape is : " + area);
            Console.WriteLine("The Perimeter of given shape is : " + perimeter);
            Console.ReadKey();
        }
    }
}
