using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Threading
{
    internal class Program
    {
        static async void Main(string[] args)
        {
            #region Threading basic operations
            // Takes on the constructor a ThreadStart which is a delegate
            // threadStart ts = new ThreadStart(PrintX);
            Thread thread = new Thread(() => PrintX(1000)); // PrintX can be encapsulated inside lambda function
                                                            // we use this way when we want to pass a function with a parameters.
                                                            // there exists another way to solve this problem using passing an object from ParameterizedThreadStart
                                                            // when using this way the start function will accept your parameter thread.start(1000)
                                                            // but the lambda function is very useful when passing more that one parameter.



            thread.Start(); // Starting the new thread, Not blocking function so
                            // we will excute also PrintY() at the same time.



            // When the parent process finishes it will wait the children processes.
            // We can change this default settings (foreground-background).
            thread.IsBackground = true; // When parent finishes the child preocesses will be closed.

            //PrintY();


            for (int i = 0; i < 1000; i++)
            {
                if (i == 700)
                    thread.Join(); // That means i tell the parent of thread (main here)
                                   // to wait this thread until it finishes.
                                   // child.join()

                thread.Join(); // Parent will wait
                Console.Write('Y');

            }

            bool HasFinished = thread.Join(TimeSpan.FromHours(2)); // Parent will wait the child for 2s without working
                                                                   // then take action.
                                                                   // TimeSpan is a struct which has some static functions converts from (Days,Minutes,Seconds) to Ms.

            // Enum to know the thread state.
            ThreadState state = thread.ThreadState;

            if (HasFinished)
                thread.Abort(); // Close the child thread. 
            #endregion

            #region Two threads write in same variable at the same time

            Helper h = new Helper();


            // Thw two threads see the same object (same data).
            Thread t1 = new Thread(h.SayHi);
            Thread t2 = new Thread(h.SayHi);

            t1.Start();
            t2.Start();
            #endregion

            #region Precreated threads (Task)
            // Task is a background
            Task task = Task.Run(() => PrintX(1000)); // static function which run the given function in a precreated thread.

            task.Wait(); // like join
            bool finished = task.Wait(TimeSpan.FromHours(2));

            // Console.WriteLine(task.Result); // Result is a blocking property
                                             // that means if the result not calculated the cw will wait for the result.

            RunAsync();




            PrintX(1000); // this line will be executed however the resault hasn't been calculated yet.

            #endregion

        }

        private static async void RunAsync()
        {
            /*
              //<Return type>
              Task<int> task2 = Task.Run(() => HasReturn());
              TaskAwaiter<int> awaiter = task2.GetAwaiter(); // Awaiter just waits the task to be completed.
              awaiter.OnCompleted(() => Console.WriteLine(task2.Result));
              // I used the those two lines to make the code continues although the result has not been calculated yet.
            */

            // The next lines do the same thing like the privous lines.

            int res = await Task.Run(() => HasReturn());
            Console.WriteLine(res);
        }

        static void PrintX(int len)
        {
            for (int i = 0; i < len; i++)
            {
                Console.Write('X');
                if (i == 500)
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                // Note that sleep function is static
                // and it will sleep the thread which this function belongs to.
            }
        }
        //static void PrintY()
        //{
        //    for (int i = 0; i < 100; i++)
        //    {
        //        Console.Write('Y');
        //    }
        //}
        static int HasReturn()
        {
            return -1;
        }
    }
}
