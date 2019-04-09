using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Context
    {
        Strategy strategy;
        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }

        // 上下文介面
        public void ContextInterface()
        {
            // 根據具體的策略物件，調用其演算法的方法
            strategy.AlgorithmInterface();
        }
    }
}
