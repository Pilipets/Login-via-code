using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Syte_Hydra
{
    class TestClass
    {
        ErrorMessage IndicateError;
        public TestClass(ErrorMessage action)
        {
            IndicateError = action;
        }
        public async void DoSomeWork()
        {
            for (int i = 0; i < 7; i++)
            {
                await Task.Run(() =>
                {
                    Thread.Sleep(3000);
                    IndicateError(i);
                });
            }
        }
    }
}
