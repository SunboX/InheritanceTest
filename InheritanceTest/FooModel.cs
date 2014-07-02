using System.Collections.Generic;

namespace InheritanceTest
{
    class FooModel : IModel<FooModelItem>
    {
        private readonly List<FooModelItem> _items;

        public FooModel()
        {
            _items = new List<FooModelItem>();
        }

        public string Name { get; set; }

        public IEnumerable<FooModelItem> Items
        {
            get { return _items; }
        }

        public void AddItem(FooModelItem item)
        {
            _items.Add(item);
        }
    }
}
