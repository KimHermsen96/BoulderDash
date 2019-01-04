using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDash.Model.LinkedList
{
    class LinkedList
    {
        private Node head;
        private Node LastAccessed;

        public bool Empty()
        {
            return head == null ? true : false;
        }

        public void AddFirst(Object data, Node top, Node bottom, Node left, Node right)
        {
            Node x = new Node(data, top, bottom, left, right);

            if(head == null)
            {
                this.head = x;
                this.LastAccessed = this.head;
            }
            else
            {
                throw new OverflowException();
            }
        }

        public void AddTop(Object data, Node top, Node bottom, Node left, Node right, Node accessor)
        {
            Node topNode = new Node(data, top, bottom, left, right);
            accessor.Top = topNode;
            topNode.Bottom = accessor;
        }

        public void AddBottom(Object data, Node top, Node bottom, Node left, Node right, Node accessor)
        {
            Node botNode = new Node(data, top, bottom, left, right);
            accessor.Bottom = botNode;
            botNode.Top = accessor;
        }

        public void AddLeft(Object data, Node top, Node bottom, Node left, Node right, Node accessor)
        {
            Node leftNode = new Node(data, top, bottom, left, right);
            accessor.Left = leftNode;
            leftNode.Right = accessor;
        }

        public void AddRight(Object data, Node top, Node bottom, Node left, Node right, Node accessor)
        {
            Node rightNode = new Node(data, top, bottom, left, right);
            accessor.Right = rightNode;
            rightNode.Left = accessor;
        }

        public Node Head
        {
            get { return this.head; }
            set { this.head = value; }
        }
    }
}
