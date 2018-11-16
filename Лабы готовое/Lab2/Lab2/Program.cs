using System.Threading;
using System;
using System.IO;
using System.Collections.Generic;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int MaxThreads = 0, MaxIOThreads = 0;

            Console.WriteLine("\"ThreadPool\" BSUiR lab2");

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
            MyThreadPool myThreadPool = new MyThreadPool(MaxThreads, MaxIOThreads);            
            // Display data
            myThreadPool.ThreadDisplay();
            //Write logs data
            myThreadPool.WriteLogs();

            Console.Read();
        }
    }

    // Custom class
    public class MyThreadPool
    {
        List<string> writeText = new List<string>();

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

            //Write log file
            writeText.Add("------------------");
            writeText.Add(string.Format("MaxThreads = {0}, MaxIOThreads {1}", this.MaxThreads.ToString(), this.MaxIOThreads.ToString()));
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
                writeText.Add("Add new task");
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
                Thread.Sleep(1000);
                //Write log file
                writeText.Add("Running thread = " + Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(1000);
            }
        }

        public void WriteLogs()
        {
            try
            {
                // If ThreadPoolLogFile.txt exists, seek to the end of the file,
                // else create a new one.
                FileStream fileStream = File.Open("ThreadPoolLogFile.txt", FileMode.Append, FileAccess.Write);
                // Encapsulate the filestream object in a StreamWriter instance.
                StreamWriter fileWriter = new StreamWriter(fileStream);
                // Write data
                foreach (var item in writeText)
                {
                    fileWriter.WriteLine(item);
                }
                
                fileWriter.Flush();
                fileWriter.Close();
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe);
            }
        }
    }
}