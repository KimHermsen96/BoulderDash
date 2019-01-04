using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDash.Model.LinkedList
{
    class Node
    {
        private object data;
        private Node top;
        private Node bottom;
        private Node left;
        private Node right;


        public Node(Object data, Node top, Node bottom, Node left, Node right)
        {
            this.data = data;
            this.top = top;
            this.bottom = bottom;
            this.left = left;
            this.right = right;
        }

        public object Data
        {
            get { return this.data; }
            set { this.data = value; }
        }
        
        public Node Top
        {
            get { return this.top; }
            set { this.top = value; }
        }

        public Node Bottom
        {
            get { return this.bottom; }
            set { this.bottom = value; }
        }

        public Node Left
        {
            get { return this.left; }
            set { this.left = value; }
        }

        public Node Right
        {
            get { return this.right; }
            set { this.right = value; }
        }
    }
}
