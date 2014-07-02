using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace InheritanceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var fooLists = new List<FooModel>();
            var barLists = new Collection<BarModel>();

            var service = new Service();

            service.DoSomethingWith(fooLists);
            service.DoSomethingWith(barLists);
        }
    }
}
