using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Linear_data_structures.Deque
{
    class UseDeque
    {
        Deque deque = new Deque();
        private void SetData()
        {
            for (int i = 0; i < 20; i++)
            {
                deque.Push_Front(i.ToString());
            }
        }

        public void Print()
        {
            Console.WriteLine("View deque:");
            this.SetData();

            while (deque.Size() != 0)
            {
                Console.WriteLine("Value: {0}", deque.Pop_Front());
            }
        }


    }

    class Deque
    {
        private ArrayList elements;  // массив с элементами

        public Deque() // конструктор класса
        {
            elements = new ArrayList();
        }

        public void Push_Back(string element)
        {
            elements.Add(element);
        }
        public string Pop_Back()
        {
            string result = (string)elements[elements.Count - 1];
            elements.RemoveAt(elements.Count - 1);
            return result;
        }
        public string Back()
        {
            return (string)elements[elements.Count - 1];
        }
        public void Push_Front(string element)
        {
            elements.Insert(0, element);
        }
        public string Pop_Front()
        {
            string result = (string)elements[0];
            elements.RemoveAt(0);
            return result;
        }
        public string Front()
        {
            return (string)elements[0];
        }
        public int Size()
        {
            return elements.Count;
        }
        public void Clear()
        {
            elements.Clear();
        }
    }

}
