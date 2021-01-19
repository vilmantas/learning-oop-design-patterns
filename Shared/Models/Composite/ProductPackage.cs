using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Shared.Models.Bridge;
using Shared.Models.ChainOfCommand;

namespace Shared.Models
{
    public class ProductPackage : InformationProduct, IComponent
    {
        private INameDisplayStrategy _nameDisplayStrategy { get; set; }

        private string _name;

        public string Name { get => _nameDisplayStrategy.DisplayName(_name); set => _name = value; }

        private List<IComponent> _children { get; set; }

        public float Price { get => _children.Aggregate(BasePrice, (price, component) => (price + component.Price)); }

        public float BasePrice { get; }

        public ProductPackage(string name, float basePrice) : this(null, name, basePrice, new DefaultNameDisplayStrategy(), null)
        {
        }

        public ProductPackage(InformationProduct parent, string name, float basePrice, string information = null) : this(parent, name, basePrice, new DefaultNameDisplayStrategy(), information)
        {
        }

        public ProductPackage(InformationProduct parent, string name, float basePrice, INameDisplayStrategy nameDisplayStrategy, string information) : base(parent, information)
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
        public void Print(int indent)
        {
            for (int i = 0; i < indent * 4; i++)
            {
                IComponent.PrinterImp.Print("-");
            }

            IComponent.PrinterImp.PrintLine($"{(indent > 0 ? "> " : "")}{Name}. Total: {Price}.");

        }
    }
}
