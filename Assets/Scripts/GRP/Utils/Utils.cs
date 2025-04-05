using System.Runtime.CompilerServices;
using UnityEngine;

namespace GRP.Utils
{
    public static class BC_Utils
    {
        public static string Header<T>()
            => "[" + nameof( T ) + "] - ";
    }
}
