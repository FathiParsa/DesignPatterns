using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPatternSample
{
    public interface ISortStrategy
    {
        void Sort(List<int> list);
    }
}
