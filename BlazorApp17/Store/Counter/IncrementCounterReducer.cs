using Blazor.Fluxor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp17.Store.Counter
{
    public class IncrementCounterReducer : Reducer<CounterState, IncrementCounterAction>
    {
        public override CounterState Reduce(CounterState state, IncrementCounterAction action)
        {
            return new CounterState(state.CurrentCount+1);
        }
    }
}
