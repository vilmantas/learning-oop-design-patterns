using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models
{
    public class Component : IComponent
    {
        private INameDisplayStrategy _nameDisplayStrategy { get; set; }

        private string _name;

        public string Name { get => _nameDisplayStrategy.DisplayName(_name); set => _name = value; }

        public float Price { get; }

        public Component(string name, float price) : this(name, price, new DefaultNameDisplayStrategy())
        {
        }

        public Component(string name, float price, INameDisplayStrategy nameDisplayStrategy)
        {
            Name = name;
            Price = price;
            _nameDisplayStrategy = nameDisplayStrategy;
        }

        public void AddComponent(IComponent component)
        {
            throw new NotImplementedException();
        }

        public void RemoveComponent(IComponent component)
        {
            throw new NotImplementedException();
        }

        public bool IsComposite() => false;

        public IEnumerable<IComponent> GetChildrenComponents()
        {
            throw new NotImplementedException();
        }
    }
}
