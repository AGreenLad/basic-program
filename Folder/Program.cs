using System;

namespace Folder
{
    class Program
    {
        private const string V = ", press any key to continue..";

        static void Main(string[] args)
        {
            string name;
            int age;
            Console.Write("Input Name: ");

            name = Convert.ToString(Console.ReadLine());

            Console.Write("Input Age: ");

            age = Convert.ToInt32(Console.ReadLine());

            if (age >= 13) {
                Console.Write(value: "Welcome, " + name + V);
                Console.ReadKey();
            }
            else    {
                Console.Write("You are not allowed, " + name + V);
                Console.ReadKey();
            }
            
        }
    }
}
