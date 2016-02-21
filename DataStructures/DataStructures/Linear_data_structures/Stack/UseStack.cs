using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Linear_data_structures.Stack
{
    class UseStack
    {
        System.Collections.Stack stack = new System.Collections.Stack();

        private void SetData()
        {
            for (int i = 0; i < 20; i++)
            {
                stack.Push(i);
            }
        }

        public void PrintStack()
        {
            Console.WriteLine("View stack:");
            this.SetData();

            while (stack.Count != 0)
            {
                Console.WriteLine("Value: {0}", stack.Pop());
            }
        }
    }
}
