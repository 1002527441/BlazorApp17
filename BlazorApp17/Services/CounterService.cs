using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp17.Services
{
    public class CounterService
    {
        public int Count { get; private set; }
        public void Increment()
        {
            Count += 1;
        }
    }
}
