using BoulderDash.Model.NLinkedList;

namespace BoulderDash.Model.Interfaces
{
    internal interface IExplodable
    {
        Node Node { get; set; }
        void Explode();
    }
}