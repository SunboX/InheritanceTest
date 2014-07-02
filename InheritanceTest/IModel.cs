using System.Collections.Generic;

namespace InheritanceTest
{
    interface IModel<out T> where T : IModelItem
    {
        string Name { get; set; }

        IEnumerable<T> Items { get; }
    }
}
