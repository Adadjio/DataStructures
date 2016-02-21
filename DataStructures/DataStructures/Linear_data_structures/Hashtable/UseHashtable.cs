using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Linear_data_structures.Hashtable
{
    class UseHashtable
    {
        System.Collections.Hashtable hashtable = new System.Collections.Hashtable();

        private void SetData()
        {
            for (int i = 0; i < 20; i++)
            {
                hashtable.Add(i, $"Number {i}");
            }
        }

        public void PrintHashtable()
        {
            Console.WriteLine("View hashtable:");
            this.SetData();

            foreach (var key in hashtable.Keys)
            {
                var value = hashtable[key].ToString();

                Console.WriteLine("Key: {0} Value: {1}", key, value);

            }

        }
    }
}
