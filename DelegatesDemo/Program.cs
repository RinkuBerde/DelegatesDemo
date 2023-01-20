using static DelegatesDemo.Demo;

namespace DelegatesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Delegates Demo!!!");
            //operation obj = new operation(Demo.Addition);
            //Console.WriteLine("Addition is = {0}", obj(23, 27));
             MulticastDelegate.ImplementDelegate();
            Console.ReadKey();
        }
    }
    
}