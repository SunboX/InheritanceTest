using System.Collections.Generic;
using System.Diagnostics;

namespace InheritanceTest
{
    class Service
    {
        public void DoSomethingWith<T>(IEnumerable<T> list) where T : IModel<IModelItem>
        {
            foreach (var model in list)
            {
                Debug.WriteLine(model.Name);

                foreach (var item in model.Items)
                {
                    Debug.WriteLine(item.Name);
                }
            }
        }
    }
}
