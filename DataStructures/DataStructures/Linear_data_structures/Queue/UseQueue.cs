using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Linear_data_structures.Queue
{
    class UseQueue
    {
        System.Collections.Queue queue = new System.Collections.Queue();

        private void SetData()
        {
            for (int i = 0; i < 20; i++)
            {
                queue.Enqueue(i);
            }
        }

        public void Print()
        {
            Console.WriteLine("View queue:");
            this.SetData();

            while (queue.Count != 0)
            {
                Console.WriteLine("Value: {0}", queue.Dequeue());
            }
        }
    }
}
