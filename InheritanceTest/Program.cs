using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace InheritanceTest
{
    class Program
    {
        static void Main()
        {
            var fooList = new List<FooModel>();
            var fooItem = new FooModelItem { Name = "Foo item 1" };
            var fooModel = new FooModel { Name = "Foo List" };
            fooModel.AddItem(fooItem);
            fooList.Add(fooModel);

            var barList = new ObservableCollection<BarModel>();
            var barItem = new BarModelItem { Name = "Bar item 1" };
            var barModel = new BarModel { Name = "Bar List" };
            barModel.AddItem(barItem);
            barList.Add(barModel);

            var service = new Service();

            service.DoSomethingWith(fooList);
            service.DoSomethingWith(barList);

            Console.ReadLine();
        }
    }
}
