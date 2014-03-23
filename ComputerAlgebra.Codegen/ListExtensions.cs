using System;
using System.Collections.Generic;

namespace Codegen
{
    internal static class ListExtensions
    {
        public static void ForEach<T>(this List<T> list, Action<T, int> action)
        {
            for(var i = 0; i < list.Count; i += 1)
            {
                action(list[i], i);
            }
        }
    }
}