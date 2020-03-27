using System;

namespace MyApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercise 2
            int A,B;
            Console.WriteLine("first number=");
            A=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("second number=");
            B=Convert.ToInt32(Console.ReadLine());
            if (A!=B)
                {
                    if (A>B)
                        Console.WriteLine(A);
                    if (A<B)
                        Console.WriteLine(B);
                }
            else
            {
                A=0; B=0;
                Console.WriteLine(A+" "+B);
            }
            //exercise 3
            Console.WriteLine("Exercise 3");
            double operand1,operand2;
            string sign;
            Console.WriteLine("first number=");
            operand1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("second number=");
            operand2=Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("What operation do you want to perform");
                 sign=Console.ReadLine();
                 switch(sign)
                 {
                      case "+": 
                    {
                        Console.WriteLine(operand1+operand2);
                        break;
                    }
                    case "-": 
                    {
                        Console.WriteLine(operand1-operand2);
                        break;
                    }
                    case "*": 
                    {
                        Console.WriteLine(operand1*operand2);
                        break;
                     }
                    case "/": 
                    {
                    if(operand2!=0)
                     {
                        Console.WriteLine(operand1/operand2);
                        break;
                    }
                    else
                        Console.WriteLine("cannot be divided by zero");
                        break;  
                    } }
                //execise 4
                Console.WriteLine("Exercise 4");
                Console.WriteLine("Please enter a number from 1 to 100");
                int a1=Convert.ToInt32(Console.ReadLine());
                    if (a1>0 && a1<14)
                    {
                        Console.WriteLine("[0,14]");
                    }
                    if (a1>15 && a1<35)
                    {
                        Console.WriteLine("15,35");
                    }
                    if (a1>36 && a1<50)
                    {
                        Console.WriteLine("[36,50]");
                    }
                    if (a1>50 && a1<100)
                    {
                        Console.WriteLine("[50,100]");
                    }
                    if (a1>100 || a1<0)
                    {
                        Console.WriteLine("not belong to any of these intervals");
                    }
            Console.ReadKey();
        }
    }
}
