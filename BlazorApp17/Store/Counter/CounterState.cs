using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp17.Store.Counter
{
    public class CounterState
    {
        public int CurrentCount { get; }

        public CounterState(int currentCount)
        {
            CurrentCount = currentCount;
        }
    }
}
