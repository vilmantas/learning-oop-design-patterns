using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models.Iterator
{
    public class SortedNodeList
    {
        private Node Head;

        public SortedNodeList(int initValue = 0)
        {
            Head = new Node
                   {
                       Value = initValue
            };
        }

        public SortedNodeListDepthFirstIterator GetIterator()
        {
            return new SortedNodeListDepthFirstIterator(this);
        }

        public Node GetHead()
        {
            return Head;
        }

        public Node AddValue(int value)
        {
            return AddValue(value, ref Head);
        }

        private static Node AddValue(int value, ref Node node)
        {
            if(node == null)
            {
                node = new Node { Value = value };
            } else if(value <= node.Value)
            {
                AddValue(value, ref node.Left);
            }
            else
            {
                AddValue(value, ref node.Right);
            }

            return null;
        }
    }
}
