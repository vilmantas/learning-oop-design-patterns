using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shared.Models
{
    public class Composite : IComponent
    {
        private INameDisplayStrategy _nameDisplayStrategy { get; set; }

        private string _name;

        public string Name { get => _nameDisplayStrategy.DisplayName(_name); set => _name = value; }

        private List<IComponent> _children { get; set; }

        public float Price { get => _children.Aggregate(BasePrice, (price, component) => (price + component.Price)); }

        public float BasePrice { get; }

        public Composite(string name, float basePrice) : this(name, basePrice, new DefaultNameDisplayStrategy())
        {
        }

        public Composite(string name, float basePrice, INameDisplayStrategy nameDisplayStrategy)
        {
            Name = name;
            BasePrice = basePrice;
            _children = new List<IComponent>();
            _nameDisplayStrategy = nameDisplayStrategy;
        }

        public void AddComponent(IComponent component)
        {
            _children.Add(component);
        }

        public void RemoveComponent(IComponent component)
        {
            _children.Remove(component);
        }

        public bool IsComposite() => true;

        public IEnumerable<IComponent> GetChildrenComponents() => _children;
    }
}
