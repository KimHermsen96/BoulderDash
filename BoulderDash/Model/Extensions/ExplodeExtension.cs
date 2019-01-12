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
            exp.Node.Data = null;
            exp.Node.Top.Data = null;
            exp.Node.Top.Right.Data = null;
            exp.Node.Top.Left.Data = null;
            exp.Node.Bottom.Data = null;
            exp.Node.Bottom.Right.Data = null;
            exp.Node.Bottom.Left.Data = null;
            exp.Node.Right.Data = null;
            exp.Node.Left.Data = null;
        }
    }
}
