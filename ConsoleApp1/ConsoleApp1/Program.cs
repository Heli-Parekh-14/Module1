using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args) //method declaration
        {
            string name = "heli";       //variable declaration and usage

            Console.WriteLine("Hello "+name);//simple hello world program with some modification


                                                         //base data type = object
            int x = (int)5.005;                          //datatype conversion
            Console.WriteLine("\nFloat to integer:"+x);

            object o1 = name;               //boxing 
            string name1 = (string)o1;      //unboxing

            if(name1==name)                 //if-else
            {
                Console.WriteLine("\nTrue[Boxing & Unboxing]");
            }
            else
            {
                Console.WriteLine("\nFalse[Boxing & Unboxing]");
            }

            Console.WriteLine("\n1.Addition\n2.Subtraction\n\nEnter choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch(choice)                  //switch 
            {
                case 1:
                    Console.WriteLine("\nEnter 2 numbers:");
                    int a= int.Parse(Console.ReadLine());
                    int b= int.Parse(Console.ReadLine());
                    Console.WriteLine("\nAddition: "+(a+b));
                    break;
                case 2:
                    Console.WriteLine("Enter 2 numbers:");
                    a = int.Parse(Console.ReadLine());
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nSubtraction: "+(a - b));
                    break;
                default:
                    Console.WriteLine("Enter valid choice !");
                    break;
            }
            Console.Read();                 //make output window wait for us to press enter
        }
    }
}
