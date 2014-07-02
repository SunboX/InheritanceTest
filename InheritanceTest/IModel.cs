using System.Collections.Generic;

namespace InheritanceTest
{
    interface IModel<T> where T : IModelItem
    {
        string Name { get; set; }

        IEnumerable<T> Items { get; set; }
    }
}
