using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Linear_data_structures.Associative_array_dictionary_or_map_
{
    class UseDictionary
    {
        Dictionary<int, string> dic = new Dictionary<int, string>();

        private void SetData()
        {
            for (int i = 0; i < 20; i++)
            {
                dic.Add(i, $"Number {i}");
            }
        }

        public void Print()
        {
            Console.WriteLine("View dictionary:");
            this.SetData();
            dic.All(x =>
            {
                Console.WriteLine("Key: {0} Value: {1}", x.Key, x.Value);
                return true;
            });
        }

    }
}
