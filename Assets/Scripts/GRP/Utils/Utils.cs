using System.Runtime.CompilerServices;
using UnityEngine;

namespace GRPU.Utils
{
    public static class GRPU_Utils
    {
        public static string Header<T>()
            => "[" + nameof( T ) + "] - ";
    }
}
