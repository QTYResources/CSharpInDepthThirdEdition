using System;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Threading;

namespace ReactiveExtensions
{
    class SelectManyWithThreadPool
    {
        static void Main()
        {
            var query = from x in Observable.Range(1, 3)
                        from y in Observable.Range(1, x, Scheduler.Default)
                        select new { x, y };
            query.Subscribe(Console.WriteLine);

            Thread.Sleep(1000);
        }
    }
}
