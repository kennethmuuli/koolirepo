using System;
using System.Collections.Generic;
using System.Text;

namespace Tund1911
{
    internal class StackTraceDemo
    {
        public void Run()
        {
            DoSomething();
        }

        private void DoSomething()
        {
            DoSomethingMore();
        }
        private void DoSomethingMore()
        {
            throw new NotImplementedException();
        }
    }
}
