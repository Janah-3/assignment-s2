using System;
using System.ComponentModel;

namespace assignment_s2
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            #region Q1
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number);

            #endregion

            #region Q2
            //Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
    

            int x = 8;
            int y = x;
            y = 6;

            Console.WriteLine(y);
            Console.WriteLine(x);
            //x value will stay 8 and y will be 6

            #endregion

            #region Q3
            //Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            string s1 = "jana";
            string s2 = s1;
            s2 = "malak";
            Console.WriteLine(s2);
            #endregion



        }
    }
}
