using System.Threading;
using System;
using System.IO;

namespace Lab3 
{
    class Program
    {
        static void Main(string[] args)
        {
            int MaxThreads = 0, MaxIOThreads = 0;

            Console.WriteLine("\"Critical section\" BSUiR lab3");

            // If this value is not > 1, repeat loop forever
            while (MaxThreads <= 0)
            {
                Console.Write("\nEnter MaxThreads: ");

                try
                {
                    MaxThreads = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Error MaxThreads, try again!");
                }

                if (MaxThreads <= 0)
                    Console.WriteLine("Error MaxThreads, try again!");
            }

            // If this value is not > 1, repeat loop forever
            while (MaxIOThreads <= 0)
            {
                Console.Write("\nEnter MaxIOThreads: ");

                try
                {
                    MaxIOThreads = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Error MaxIOThreads, try again!");
                }

                if (MaxIOThreads <= 0)
                    Console.WriteLine("Error MaxIOThreads, try again!");
            }

            // Creating object and set base parameters
            MyThreadPool myThreadPool = new MyThreadPool(MaxIOThreads, MaxIOThreads);
            // Display data
            myThreadPool.ThreadDisplay();
            
            Console.Read();
        }
    }

    // Custom class
    public class MyThreadPool
    {
        // Base properties of thread
        int MaxThreads { get; set; }
        int MaxIOThreads { get; set; }

        // Constructor with parameters
        public MyThreadPool(int MaxThreads, int MaxIOThreads)
        {
            this.MaxThreads = MaxThreads;
            // Set max count of threads and input/output thread (I/O)
            this.MaxIOThreads = MaxIOThreads;
            ThreadPool.SetMaxThreads(this.MaxThreads, this.MaxIOThreads);

            // Write log file
            // Critical section
            lock (this)
            {
                WriteLogs("------------------");
                WriteLogs(string.Format("MaxThreads = {0}, MaxIOThreads {1}", this.MaxThreads.ToString(), this.MaxIOThreads.ToString()));
                Thread.Sleep(1000);
            }
        }

        public void ThreadDisplay()
        {
            // Get our set settings previously installed
            ThreadPool.GetMaxThreads(out int nWorkerThreads, out int nCompletionThreads);

            // Display this info
            Console.WriteLine("\nMaximum number of threads: " + nWorkerThreads + "\nI / O streams available: " + nCompletionThreads + "\n");

            // Run loop when are calling method and display it
            for (int i = 0; i < 5; i++)
            {
                // Write log file
                // Critical section, running only one thread!
                lock (this)
                {
                    WriteLogs("Add new task");
                    Thread.Sleep(1000);
                }
                ThreadPool.QueueUserWorkItem(new WaitCallback(JobForAThread));
            }
        }

        // state - optional parameter
        void JobForAThread(object state)
        {
            for (int i = 0; i < 3; i++)
            {
                // Display current thread and current iterator
                Console.WriteLine("\nloop {0}, execution inside a thread from the pool {1}", i, Thread.CurrentThread.ManagedThreadId);
                // Write log file
                // Critical section, running only one thread!
                lock (this)
                {
                    WriteLogs("Running thread = " + Thread.CurrentThread.ManagedThreadId);
                    Thread.Sleep(1000);
                }                
                Thread.Sleep(1000);
            }
        }

        public void WriteLogs(string data)
        {
            // Critical section, running only one thread!
            lock (this)
            {
                Console.WriteLine("\nRunning critical section by " + Thread.CurrentThread.ManagedThreadId + " thread!");

                try
                {
                    // If ThreadPoolLogFile.txt exists, seek to the end of the file,
                    // else create a new one.
                    FileStream fileStream = File.Open("CriticalSectionLogs.txt", FileMode.Append, FileAccess.Write);
                    // Encapsulate the filestream object in a StreamWriter instance.
                    StreamWriter fileWriter = new StreamWriter(fileStream);
                    // Write data
                    fileWriter.WriteLine(data);

                    fileWriter.Flush();
                    fileWriter.Close();
                }
                catch (IOException ioe)
                {
                    Console.WriteLine(ioe);
                }

                Thread.Sleep(1000);
            }
        }
    }
}