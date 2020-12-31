using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models.Iterator
{
    public class BinaryTree : IEnumerable<Node>
    {
        private Node Head;
        
        public BinaryTreeFirstIterator GetIterator()
        {
            return new BinaryTreeFirstIterator(this);
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
                return AddValue(value, ref node.Left);
            }
            else
            {
                return AddValue(value, ref node.Right);
            }

            return node;
        }

        public IEnumerator<Node> GetEnumerator()
        {
            return new BinaryTreeFirstIterator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new BinaryTreeFirstIterator(this);
        }
    }
}
