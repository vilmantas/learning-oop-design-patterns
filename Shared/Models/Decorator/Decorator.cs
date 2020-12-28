using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models.Decorator
{
    public abstract class Decorator : IComponent
    {
        protected IComponent _component;

        public virtual string Name => _component.Name;

        public virtual float Price => _component.Price;

        public Decorator(IComponent component)
        {
            _component = component;
        }

        public virtual void AddComponent(IComponent component) => this._component.AddComponent(component);

        public virtual IEnumerable<IComponent> GetChildrenComponents() => _component.GetChildrenComponents();

        public virtual bool IsComposite() => _component.IsComposite();

        public virtual void RemoveComponent(IComponent component) => this._component.RemoveComponent(component);

        public virtual void Print(int indent) => this._component.Print(indent);
    }
}
