using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using Slusser.Collections.Generic;

namespace DataStructures.Linear_data_structures.Buffer_gap
{
    class TestGrapBufer
    {
        #region Fields

        private static Stopwatch stopwatch;

        #endregion Fields


        #region Print

        public static void Print()
        {
            stopwatch = new Stopwatch();

            // Test random insert performance
            Console.WriteLine();
            TestRandomInsert();

            // Test insert performance
            Console.WriteLine();
            TestInsert();

            // Test random remove performance
            Console.WriteLine();
            TestRandomRemoveAt();

            // Test remove performance
            Console.WriteLine();
            TestRemoveAt();
        }

        #endregion Main


        #region Tests

        private static void TestRandomRemoveAt()
        {
            const int iterations = 200000;
            Random r = new Random();
            Console.WriteLine("Removing {0:0,0} items randomly from each collection: ", iterations);

            int[] items = new int[iterations];
            for (int i = 0; i < items.Length; i++)
                items[i] = i;

            List<int> list = new List<int>(items);
            list.Capacity = items.Length;
            stopwatch.Reset();
            stopwatch.Start();
            for (int i = items.Length - 1; i >= 0; i--)
                list.RemoveAt(r.Next(i));
            stopwatch.Stop();
            Trace.Assert(list.Count == 0);
            Console.WriteLine("List<int> time: {0:0,0}ms", stopwatch.ElapsedMilliseconds);

            GapBuffer<int> buffer = new GapBuffer<int>();
            buffer.AddRange(items);
            buffer.Capacity = items.Length;
            stopwatch.Reset();
            stopwatch.Start();
            for (int i = items.Length - 1; i >= 0; i--)
                buffer.RemoveAt(r.Next(i));
            stopwatch.Stop();
            Trace.Assert(buffer.Count == 0);
            Console.WriteLine("GapBuffer<int> time: {0:0,0}ms", stopwatch.ElapsedMilliseconds);
        }

        private static void TestRandomInsert()
        {
            const int iterations = 200000;
            Random r = new Random();
            Console.WriteLine("Inserting {0:0,0} items randomly into each collection: ", iterations);

            List<int> list = new List<int>();
            list.Capacity = iterations;
            list.Add(0);
            stopwatch.Reset();
            stopwatch.Start();
            for (int i = 1; i < iterations; i++)
            {
                list.Insert(r.Next(i), i);
            }
            stopwatch.Stop();
            Trace.Assert(list.Count == iterations);
            Trace.Assert(list.Capacity == iterations);
            Console.WriteLine("List<int> time: {0:0,0}ms", stopwatch.ElapsedMilliseconds);


            GapBuffer<int> buffer = new GapBuffer<int>();
            buffer.Capacity = iterations;
            buffer.Add(0);
            stopwatch.Reset();
            stopwatch.Start();
            for (int i = 1; i < iterations; i++)
            {
                buffer.Insert(r.Next(i), i);
            }
            stopwatch.Stop();
            Trace.Assert(buffer.Count == iterations);
            Trace.Assert(buffer.Capacity == iterations);
            Console.WriteLine("GapBuffer<int> time: {0:0,0}ms", stopwatch.ElapsedMilliseconds);
        }

        private static void TestRemoveAt()
        {
            const int iterations = 200000;
            Console.WriteLine("Removing {0:0,0} items from the beginning of each collection: ", iterations);

            int[] items = new int[iterations];
            for (int i = 0; i < items.Length; i++)
                items[i] = i;

            List<int> list = new List<int>(items);
            list.Capacity = items.Length;
            stopwatch.Reset();
            stopwatch.Start();
            for (int i = 0; i < items.Length; i++)
                list.RemoveAt(0);
            stopwatch.Stop();
            Console.WriteLine("List<int> time: {0:0,0}ms", stopwatch.ElapsedMilliseconds);

            GapBuffer<int> buffer = new GapBuffer<int>();
            buffer.AddRange(items);
            buffer.Capacity = items.Length;
            stopwatch.Reset();
            stopwatch.Start();
            for (int i = 0; i < items.Length; i++)
                buffer.RemoveAt(0);
            stopwatch.Stop();
            Console.WriteLine("GapBuffer<int> time: {0:0,0}ms", stopwatch.ElapsedMilliseconds);
        }

        private static void TestInsert()
        {
            const int iterations = 200000;
            Console.WriteLine("Inserting {0:0,0} items into the beginning of each collection: ", iterations);

            List<int> list = new List<int>();
            list.Capacity = iterations;
            stopwatch.Reset();
            stopwatch.Start();
            for (int i = 0; i < iterations; i++)
            {
                list.Insert(0, i);
            }
            stopwatch.Stop();
            Trace.Assert(list.Count == iterations);
            Trace.Assert(list.Capacity == iterations);
            Console.WriteLine("List<int> time: {0:0,0}ms", stopwatch.ElapsedMilliseconds);

            GapBuffer<int> buffer = new GapBuffer<int>();
            buffer.Capacity = iterations;
            stopwatch.Reset();
            stopwatch.Start();
            for (int i = 0; i < iterations; i++)
            {
                buffer.Insert(0, i);
            }
            stopwatch.Stop();
            Trace.Assert(buffer.Count == iterations);
            Trace.Assert(buffer.Capacity == iterations);
            Console.WriteLine("GapBuffer<int> time: {0:0,0}ms", stopwatch.ElapsedMilliseconds);
        }

        #endregion Tests
    }
}

