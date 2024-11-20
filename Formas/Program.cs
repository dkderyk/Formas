using System;
using Formas.Enums;
using Formas.Entitis;
using System.Collections.Generic;

namespace Formas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantidade de figuras: ");
            int n = int.Parse(Console.ReadLine());

            List<Shape> list = new List<Shape>();
            for (int i = 0; i < n; i++)
            {
                Console.Write("Rectangle or Circle (r/c): ");
                char _shape = char.Parse(Console.ReadLine());
            
 /*             bool val;*/
                Color color;

                Console.Write("Color (Black; Red; Blue): ");
                color = Enum.Parse<Color>(Console.ReadLine());
                
                switch (_shape)
                {
                    case 'r':
                        Console.Write("Width: ");
                        double width = double.Parse(Console.ReadLine());

                        Console.Write("Height: ");
                        double height = double.Parse(Console.ReadLine());

                        list.Add(new Rectangle(color, width, height));
                        break;

                    case 'R':
                        Console.Write("Width: ");
                        width = double.Parse(Console.ReadLine());

                        Console.Write("Height: ");
                        height = double.Parse(Console.ReadLine());

                        list.Add(new Rectangle(color, width, height));
                        break;

                    case 'c':
                        Console.Write("Radius: ");
                        double radius = double.Parse(Console.ReadLine());

                        list.Add(new Circle(color, radius));
                        break;

                    case 'C':
                        Console.Write("Radius: ");
                        radius = double.Parse(Console.ReadLine());

                        list.Add(new Circle(color, radius));
                        break;
                }
            }

            Console.WriteLine("Saida ...");

            foreach (Shape sh in list)
            {
                double area = sh.Area();

                Console.WriteLine(area);
            }
        }
    }
}