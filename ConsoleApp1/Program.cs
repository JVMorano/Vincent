using System;

namespace Aritmethic
{

    public class Math
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Sub(int num1, int num2)
        {
            return num1 - num2;
        }
        public int Mul(int num1, int num2)
        {
            return num1 * num2;
        }
        public int Div(int num1, int num2)
        {
            return num1 / num2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();

            int num1, num2;

            //Add
            Console.WriteLine("Additional");
            Console.WriteLine("Enter num1:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2:");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Total = " + math.Add(num1, num2));



            //Sub
            Console.WriteLine("Subtract");
            Console.WriteLine("Enter num1:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2:");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Total = " + math.Sub(num1, num2));



            //Mul
            Console.WriteLine("Multiply");
            Console.WriteLine("Enter num1:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2:");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Total = " + math.Mul(num1, num2));



            //Div
            Console.WriteLine("Division");
            Console.WriteLine("Enter num1:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2:");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Total = " + math.Div(num1, num2));


        }


    }

}



