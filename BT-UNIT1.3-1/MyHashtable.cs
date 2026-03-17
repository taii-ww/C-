using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_UNIT1._3_1
{
    internal class MyHashtable
    {
        public Hashtable ht = new Hashtable();
        public void hashtable()
        {
            ht.Add(1, "an");
            ht.Add(2, "binh");
            ht.Add(3, "duong");

            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }
        }
    }
}
