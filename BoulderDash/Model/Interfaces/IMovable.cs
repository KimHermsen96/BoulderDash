using System;

namespace BoulderDash.Model.Interfaces
{
    public interface IMovable 
    {
        void Move();
        Action<IMovable> DisposeAction { get; set; }
    }
}
