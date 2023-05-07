using System.Runtime.CompilerServices;

namespace destruction
{
    internal class Program
    {
        static void Main(string[] args)
        {

            person s1 = new person(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
            Console.WriteLine("Hello, my name is " + s1.name);
            Console.WriteLine("Hello, my name is " + s1.name2);
            Console.WriteLine("Hello, my name is " + s1.name3);

        }
    }
}