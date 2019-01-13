using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDash.Model.AbstractClasses;
using BoulderDash.Model.Interfaces;

namespace BoulderDash.Model.NLinkedList
{
    public class LinkedList
    {
        private Node _head;
        private Node _lastAccessed;
        private Node _secondLastRowFirstColumn;
        private Node _secondLastRowColumnIterator;

        public bool Empty()
        {
            return _head == null ? true : false;
        }

        public void AddFirst(Node x)
        {
            if(_head == null)
            {
                this._head = x;
                this._lastAccessed = this._head;
                this._secondLastRowFirstColumn = this._head;
            }
            else
            {
                throw new OverflowException();
            }
        }

        
        public void AppendRightAndBreak(bool newLine, Drawable data)
        {
            Node x = new Node(data);

            if (data != null) data.Node = x;

            if(Empty())
            {
                AddFirst(x);
                return;
            }

            if (newLine)
            {
                _lastAccessed = x;
                _secondLastRowColumnIterator = _secondLastRowFirstColumn;
                _secondLastRowColumnIterator.Bottom = x;
                x.Top = _secondLastRowColumnIterator;
                _secondLastRowColumnIterator = _secondLastRowColumnIterator.Right;

                _secondLastRowFirstColumn = _lastAccessed;
            }
            else
            {
                if(_secondLastRowColumnIterator != null)
                {
                    _secondLastRowColumnIterator.Bottom = x;
                    x.Top = _secondLastRowColumnIterator;
                    _secondLastRowColumnIterator = _secondLastRowColumnIterator.Right;
                }
                _lastAccessed.Right = x;
                x.Left = _lastAccessed;
                _lastAccessed = x;
            }
            
        }

        public Node Head
        {
            get { return this._head; }
            set { this._head = value; }
        }
    }
}
