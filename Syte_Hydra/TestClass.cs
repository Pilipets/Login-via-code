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
        public void DoSomeWork()
        {
            List<Task> tasksList = new List<Task>();
            CancellationTokenSource token = new CancellationTokenSource();
            for (int i = 0; i < 10; i++)
            {
                Task checkTask = new Task(() => Login(i,token));
                checkTask.Start();
    
                tasksList.Add(checkTask);
            }
            Task.WaitAll(tasksList.ToArray());
            IndicateError("Finished brute");
        }
        private void Login(int x, CancellationTokenSource tokenSource)
        {
            if (!tokenSource.IsCancellationRequested)
            {
                Thread.Sleep(3000);
                IndicateError("Checking " + x.ToString());
                if (x == 2000)
                    tokenSource.Cancel();
            }
        }
        public void DoSomeWork2()
        {
            Task.Run(async () =>
            {
                CancellationTokenSource token = new CancellationTokenSource();
                for (int i = 0; i < 10; i++)
                {
                    await Task.Run(() => Login(i, token));
                }
                IndicateError("Finished brute");
            });
        }
    }
}
