using lib_netstd2;
using System;

namespace console_net48
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var need = new ClassYouNeedToReference();

            Console.WriteLine($"Hello from console_net48!");

            Console.ReadLine();
        }
    }

    public class ClassFromNet48
    {

    }
}
