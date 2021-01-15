using System;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Taking input from user

            Console.Write("Please give your name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Output is : " +name);

            Console.Write("Enter Your first Number : ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please Enter Your second Number : ");
            int secondNumber =Convert.ToInt32(Console.ReadLine());
            int add = firstNumber + secondNumber;
            int sub = firstNumber - secondNumber;
            int mul = firstNumber * secondNumber;
            int div = firstNumber / secondNumber;
            int rem = firstNumber % secondNumber;

            Console.WriteLine("Result : " +add);
            Console.WriteLine("Result : " + sub);
            Console.WriteLine("Result : " + mul);
            Console.WriteLine("Result : " + div);
            Console.WriteLine("Result : " + rem);

            Console.ReadKey();
            
            
            
            
            
            //variable


        /*  string name = "Jubair Ahmed Junjun";
            int age = 20;
            double phone = 08549xxx;
            bool b = true;
            Console.WriteLine(name + "\n" + age + "\n" + phone +"\n"+ b);
            Console.ReadLine();

         */
            
            
            //Hello world print
        
            
         /*
            Console.WriteLine("Hello World!");
            Console.ReadLine();
         */
        }
    }
}
