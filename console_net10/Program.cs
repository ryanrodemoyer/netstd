using lib_net48;
using lib_netstd2;

namespace console_net10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var need = new ClassYouNeedToReference();

            var need2 = new ClassFromLib48();

            Console.WriteLine($"Hello from console_net10!");

            Console.ReadLine();
        }
    }
}
