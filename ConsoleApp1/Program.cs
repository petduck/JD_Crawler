using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var washMachine = "https://search.jd.com/Search?keyword=%E6%B4%97%E8%A1%A3%E6%9C%BA&enc=utf-8&wq=xi%27yi%27ji&pvid=e60b5e7735d94666a14f241dadd87e42";
            HTMLProcess.GetProductList(washMachine);
            Console.Read();
        }
    }
}
