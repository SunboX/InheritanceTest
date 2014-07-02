using System.Collections.Generic;
using System.Diagnostics;

namespace InheritanceTest
{
    class Service
    {
        public void DoSomethingWith<T>(IEnumerable<T> list) where T : IModel<IModelItem>
        {
            Debug.WriteLine(list);
        }
    }
}
