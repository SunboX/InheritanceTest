using System.Collections.Generic;

namespace InheritanceTest
{
    class FooModel : IModel<FooModelItem>
    {
        public FooModel()
        {
            Items = new List<FooModelItem>();
        }

        public string Name { get; set; }
        public IEnumerable<FooModelItem> Items { get; set; }
    }
}
