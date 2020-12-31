using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models.Iterator
{
    public interface IIterator<out T>
    {
        void First();
        void Next();
        bool IsDone();
        T CurrentItem();
    }
}
