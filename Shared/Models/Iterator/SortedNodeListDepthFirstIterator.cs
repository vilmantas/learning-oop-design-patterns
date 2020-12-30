using System;
using System.Collections.Generic;
using System.Text;
using Shared.Helpers;

namespace Shared.Models.Iterator
{
    public class SortedNodeListDepthFirstIterator
    {
        private readonly SortedNodeList _list;

        public SortedNodeListDepthFirstIterator(SortedNodeList List)
        {
            _list = List;
        }

        public void InternalPrintTraverse()
        {
            Print(_list.GetHead());
        }

        private void Print(Node node)
        {
            if (node.Left != null) Print(node.Left);
            if (node.Right != null) Print(node.Right);

            Console.WriteLine(node.Value);
        }
    }
}
