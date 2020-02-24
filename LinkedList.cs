using System;

namespace Project2
{
    public class LinkedList
    {
        private class Node
        {
            internal int head;
            internal Node tail;

            public Node(int head, Node tail)
            {
                this.head = head;
                this.tail = tail;
            }
        }

        private Node root;

        public LinkedList()
        {
            root = null;
        }

        public void AddFront(int element)
        {
            root = new Node(element, root);
        }

        public void AddBack(int element)
        {
            if (root == null)
            {
                root = new Node(element, null);
            }
            else
            {
                Node current = root;
                while (current.tail != null)
                {
                    current = current.tail;
                }
                current.tail = new Node(element, null);
            }
        }

        public int GetElementAt(int index)
        {
            if (index < 0)
            {
                throw new NoSuchElementException("Negative indices aren't permitted");
            }

            int curPos = 0;
            Node current = root;

            while (curPos < index && current != null)
            {
                current = current.tail;
                curPos++;
            }

            if (current == null)
            {
                throw new NoSuchElementException($"No element at index: {index}");
            }
            else
            {
                if (curPos != index)
                {
                    throw new InvalidOperationException("Fatal error, curPos != index");
                }
                return current.head;
            }
        }

        public int Length
        {
            get
            {
                int len = 0;
                Node current = root;
                while (current != null)
                {
                    len++;
                    current = current.tail;
                }
                return len;
            }
        }

        public int[] ToArray()
        {
            int[] result = new int[Length];
            Node current = root;
            int index = 0;
            while (current != null)
            {
                result[index] = current.head;
                current = current.tail;
                index++;
            }
            return result;
        }

        public void MysteryOperation()
        {
            // The mystery operation reverses the order of the list.
            // Easiest way to do this is grab a local copy, set list to empty
            // and then AddFront each item.
            Node current = root;
            root = null;
            while (current != null)
            {
                AddFront(current.head);
                current = current.tail;
            }
        }
    }
}
