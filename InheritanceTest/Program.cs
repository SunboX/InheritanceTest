using System.Collections.Generic;

namespace InheritanceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var fooLists = new List<FooModel>();
            var barLists = new List<BarModel>();

            var service = new Service();

            service.DoSomethingWith(fooLists);
            service.DoSomethingWith(barLists);
        }
    }
}
