using System.Collections.Generic;

namespace InheritanceTest
{
    class BarModel : IModel<BarModelItem>
    {
        private readonly List<BarModelItem> _items;

        public BarModel()
        {
            _items = new List<BarModelItem>();
        }

        public string Name { get; set; }

        public IEnumerable<BarModelItem> Items
        {
            get { return _items; }
        }

        public void AddItem(BarModelItem item)
        {
            _items.Add(item);
        }
    }
}
