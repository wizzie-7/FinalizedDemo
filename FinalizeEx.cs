using System;
using System.Diagnostics;

namespace FinalizedDemo
{
    public class FinalizeOperation
    {
        Stopwatch sp;
        public FinalizeOperation()
        {
            sp = Stopwatch.StartNew();
            Console.WriteLine("StopWatch Strted");
        }
        public void showDuration()
        {
            Console.WriteLine("This instance of {0} has been in existence for {1}", this, sp.Elapsed);
        }
        ~FinalizeOperation()
        {
            Console.WriteLine("Finalizing object");
            sp.Stop();
            Console.WriteLine("This instance of {0} has been in existence for {1}",this, sp.Elapsed);
        }
    }
    class FinalizeEx
    {
        static void Main(string[] args)
        {
            FinalizeOperation FO = new FinalizeOperation();
            FO.showDuration();
        }
    }
}
