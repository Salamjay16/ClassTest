/*Name: ADEYANJU Abdulsalam Tp
Department: Electrical-Electrical Engineering
Matric number: EES/18/19/0074
Course Code: EEG 323*/  
using System;

namespace Crammers
{
    class Solutions
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of a");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of b");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of c");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of d");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of e");
            int e = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value of f");
            int f = Convert.ToInt32(Console.ReadLine());

            double s = e*d - f*b;
            double t = a*d - b*c;

            double r = a*f - e*c;
            double q = a*d - b*c;

            double x = s/t;
            double y = r/t;



            if (q == 0)
            {
                System.Console.WriteLine("The equation has no solution");
            }
            else
            {
                System.Console.WriteLine("x is:" +x);
                System.Console.WriteLine("y is:" +y);
            }

        }
    }
}