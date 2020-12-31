using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Shared.Helpers;

namespace Shared.Models.Iterator
{
    public class BinaryTreeIterator : IIterator<Node>, IEnumerator<Node>
    {
        private readonly BinaryTree _list;
        private Node _currentNode { get; set; }

        private readonly Node HeadPointer = new Node();

        private readonly Stack<Node> _traversedNodes = new Stack<Node>();

        public BinaryTreeIterator(BinaryTree List)
        {
            _list = List;
            HeadPointer.Left = _list.GetHead();
            Reset();
        }

        public void InternalPrintTraverse()
        {
            Print(_list.GetHead());
        }

        private static void Print(Node node)
        {
            if (node.Left != null) Print(node.Left);
            if (node.Right != null) Print(node.Right);

            Console.WriteLine(node.Value);
        }

        public void First() => _currentNode = _list.GetHead();

        public void Next() => MoveNext();

        public bool IsDone() => CurrentItem() == null;







        public Node CurrentItem() => _currentNode;
        public bool MoveNext()
        {
            var parent = _currentNode;

            if(_currentNode.Left == null && _currentNode.Right == null)
            {
                _currentNode = _traversedNodes.TryPop(out Node nextNode) ? nextNode.Right : null;
            }
            else
            {
                _currentNode = _currentNode.Left ?? _currentNode.Right;
            }

            if (parent.Left != null && parent.Right != null)
            {
                _traversedNodes.Push(parent);
            }

            return _currentNode != null;
        }

        public void Reset() => _currentNode = HeadPointer;
        object IEnumerator.Current => Current;

        public Node Current => _currentNode;

        public void Dispose()
        {
            _currentNode = null;
        }
    }
}
