using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadingTutorial
{
    class Program
    {
        static void Main(string[] args)
        {

            /*new Thread(() =>
            {
                Console.WriteLine("Thread 1");
            }).Start();

            new Thread(() =>
            {
                Console.WriteLine("Thread 2");
            }).Start();

            new Thread(() =>
            {
                Console.WriteLine("Thread 3");
            }).Start();

            new Thread(() =>
            {
                Console.WriteLine("Thread 4");
            }).Start();*/

            var taskCompletionSource = new TaskCompletionSource<bool>();

            var thread = new Thread(() =>
            {
                Thread.Sleep(100);
                taskCompletionSource.TrySetResult(true);
            });
            Console.WriteLine(thread.ManagedThreadId);
            thread.Start();

            var test = taskCompletionSource.Task.Result;
        }
    }
}
