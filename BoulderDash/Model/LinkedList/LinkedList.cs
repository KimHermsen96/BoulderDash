using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDash.Model.Interfaces;

namespace BoulderDash.Model.LinkedList
{
    public class LinkedList
    {
        private Node head;
        private Node LastAccessed;
        private Node SecondLastRowFirstColumn;
        private Node SecondLastRowColumnIterator;

        public bool Empty()
        {
            return head == null ? true : false;
        }

        public void AddFirst(Node x)
        {
            if(head == null)
            {
                this.head = x;
                this.LastAccessed = this.head;
                this.SecondLastRowFirstColumn = this.head;
              
            }
            else
            {
                throw new OverflowException();
            }
        }

        
        public void AppendRightAndBreak(bool newLine, IDrawable data)
        {
            Node x = new Node(data, null, null, null, null);
            if(data != null) data.Node = x;
            if(Empty())
            {
                AddFirst(x);
                return;
            }

            if (newLine)
            {
                LastAccessed = x;
                SecondLastRowColumnIterator = SecondLastRowFirstColumn;
                SecondLastRowColumnIterator.Bottom = x;
                x.Top = SecondLastRowColumnIterator;
                SecondLastRowColumnIterator = SecondLastRowColumnIterator.Right;

                SecondLastRowFirstColumn = LastAccessed;
            }
            else
            {
                if(SecondLastRowColumnIterator != null)
                {
                    SecondLastRowColumnIterator.Bottom = x;
                    x.Top = SecondLastRowColumnIterator;
                    SecondLastRowColumnIterator = SecondLastRowColumnIterator.Right;
                }
                LastAccessed.Right = x;
                x.Left = LastAccessed;
                LastAccessed = x;
            }
            
        }

        public Node Head
        {
            get { return this.head; }
            set { this.head = value; }
        }
    }
}
