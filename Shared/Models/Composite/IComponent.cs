using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models
{
    public interface IComponent
    {
        string Name { get; }
        float Price { get; }

        void AddComponent(IComponent component);
        void RemoveComponent(IComponent component);
        bool IsComposite();
        IEnumerable<IComponent> GetChildrenComponents();
    }
}
