using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingAssignment
{
    class Program
    {
        public static void CallTochildThread() {
            int a = 0;
            try
            {
                for (int i = 0; i < 10; i++) {
                    Thread.Sleep(100);
                    Console.Write(".");
                }
                Console.WriteLine();
                Console.WriteLine(t.ThreadState);
            }
            catch (Exception ex) {
                Console.WriteLine("THe error at "+ex);
            }

        }
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(CallTochildThread));
            Console.WriteLine(t.ThreadState);
            t.Start();
            Console.WriteLine(t.ThreadState);
        }
    }
}
