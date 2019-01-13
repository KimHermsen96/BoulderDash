using System;
using BoulderDash.Model.AbstractClasses;

namespace BoulderDash.Model.NLinkedList
{
    public class Node
    {
        public Node(Drawable data)
        {
            Data = data;
        }

        public Drawable Data { get; set; }

        public Node Top { get; set; }

        public Node Bottom { get; set; }

        public Node Left { get; set; }

        public Node Right { get; set; }
    }
}
