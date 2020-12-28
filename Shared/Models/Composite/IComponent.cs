using System;
using System.Collections.Generic;
using System.Text;
using Shared.Models.Bridge;

namespace Shared.Models
{
    public interface IComponent
    {
        static IPrinterImp PrinterImp = new FilePrinterImp();
        string Name { get; }
        float Price { get; }

        void AddComponent(IComponent component);
        void RemoveComponent(IComponent component);
        bool IsComposite();
        IEnumerable<IComponent> GetChildrenComponents();
        void Print(int indent);
    }
}
