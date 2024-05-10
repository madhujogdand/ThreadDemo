using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Threading;


namespace ThreadDemo
{
    
    public class Demo
    { 
       public void Print1() 
        { 
          for (int i = 1; i <= 10; i++) 
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }
        public void Print2()
        {
            for (int i = 11; i <= 20; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }
    }
    //Lock Keyword
    //public class demo
    //{
    //    public void print1()
    //    {
    //        lock(this)
    //        {
    //            for (int i = 1; i <= 10; i++)
    //            {
    //                console.writeline(i);
    //                thread.sleep(1000);
    //            }
    //        }
    //    }
    //    public void print2()
    //    {
    //        for (int i = 11; i <= 20; i++)
    //        {
    //            console.writeline(i);
    //            thread.sleep(1000);
    //        }
    //    }
    //}

    //[Synchronize] attribute

    //[Synchronization]
    //public class demo
    //{
    //    public void print1()
    //    {
    //        lock (this)
    //        {
    //            for (int i = 1; i <= 10; i++)
    //            {
    //                console.writeline(i);
    //                thread.sleep(1000);
    //            }
    //        }
    //    }
    //    public void print2()
    //    {
    //        for (int i = 11; i <= 20; i++)
    //        {
    //            console.writeline(i);
    //            thread.sleep(1000);
    //        }
    //    }
    //}
    public class Program
    {
        static void Main(string[] args)
        {
            Demo demo = new Demo();
            Thread t1 = new Thread(new ThreadStart(demo.Print1));
            t1.Start();
            Thread t2 = new Thread(new ThreadStart(demo.Print2));
            t2.Start();
        }
    }
}
