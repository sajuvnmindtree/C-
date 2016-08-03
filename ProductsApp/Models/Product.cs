
using System.Collections.Generic;

namespace ProductsApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }

    public class HierarchyInfo
    {
        public string Title { get; set; }
        public string Value { get; set; }
        public string Id { get; set; }
        public List<HierarchyInfo> Children { get; set; }
        public bool HasChildren
        {
            get
            {
                return (Children != null) && (Children.Count > 0);
            }

        }

        public static List<HierarchyInfo> TestGetLocations()
        {

            var locations = new List<HierarchyInfo>();

            for (int i = 0; i < 100; i++)
            {
                locations.Add(new HierarchyInfo()
                {
                    Children = null,
                    Id = i.ToString(),
                    Title = i.ToString(),
                    Value = i.ToString()

                });
            };
            // add some children to each item
            foreach (var item in locations)
            {
                var children = new List<HierarchyInfo>();
                for (int i = 0; i < 10; i++)
                {
                    var childlocation  = new HierarchyInfo()
                    {
                        Children = null,
                        Id = i.ToString(),
                        Title = i.ToString(),
                        Value = i.ToString()

                    };

                    children.Add(childlocation);
                };

                item.Children = children;
            }

            return locations;
        }
    }
}