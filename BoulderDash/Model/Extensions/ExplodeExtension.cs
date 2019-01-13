using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoulderDash.Model.Interfaces;
using BoulderDash.Model.NLinkedList;

namespace BoulderDash.Model.Extensions
{
    internal static class ExplodeExtensions
    {
        public static void ExplodeExt(this IExplodable exp)
        {
            exp.Node.Top.Data?.Destroy();
            exp.Node.Top.Right.Data?.Destroy();
            exp.Node.Top.Left.Data?.Destroy();
            exp.Node.Bottom.Data?.Destroy();
            exp.Node.Bottom.Right.Data?.Destroy();
            exp.Node.Bottom.Left.Data?.Destroy();
            exp.Node.Right.Data?.Destroy();
            exp.Node.Left.Data?.Destroy();
            exp.Node.Data?.Destroy();
        }
    }
}
