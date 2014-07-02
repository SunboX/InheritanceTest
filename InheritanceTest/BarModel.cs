using System.Collections.Generic;

namespace InheritanceTest
{
    class BarModel : IModel<BarModelItem>
    {
        public BarModel()
        {
            Items = new List<BarModelItem>();
        }

        public string Name { get; set; }
        public IEnumerable<BarModelItem> Items { get; set; }
    }
}
