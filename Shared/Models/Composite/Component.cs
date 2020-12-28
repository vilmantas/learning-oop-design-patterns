using System;
using System.Collections.Generic;
using System.Text;
using Shared.Models.Bridge;

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

        public void Print(int indent)
        {
            for (int i = 0; i < indent * 4; i++)
            {
                IComponent.PrinterImp.Print("-");
            }

            IComponent.PrinterImp.PrintLine($"{(indent > 0 ? "> " : "")}{Name}. Price: {Price}.");
        }
    }
}
