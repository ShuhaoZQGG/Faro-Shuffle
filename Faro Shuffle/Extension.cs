﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Faro_Shuffle
{
    public static class Extension
    {
        // You can see the addition of the this modifier on the first argument to the method.
        // That means you call the method as though it were a member method of the type of the first argument.
        // example: first.InterLeaveSequenceWith(second) === InterLeaveSequenceWith(first, second)
        public static IEnumerable<T> InterLeaveSequenceWith<T>
            (this IEnumerable<T> first, IEnumerable<T> second)
        {
            var firstIter = first.GetEnumerator();
            var secondIter = second.GetEnumerator();

            while (firstIter.MoveNext() && secondIter.MoveNext())
            { 
                yield return firstIter.Current;
                yield return secondIter.Current;
            }
        }

        public static bool SequenceEquals<T>
            (this IEnumerable<T> first, IEnumerable<T> second)
        {
            var firstIter = first.GetEnumerator();
            var secondIter = second.GetEnumerator();

            while (firstIter.MoveNext() && secondIter.MoveNext()) 
            {
                if (!firstIter.Current.Equals(secondIter.Current))
                { 
                    return false;
                }
            }

            return true;
        }
    }
}
