using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            onDicCall();
            Console.ReadLine();
        }
        static void onHashTableCall()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("1", "one");
            hashtable.Add("2", "two");
            hashtable.Add(3,"three");
            hashtable.Add("aa", "321");


            Console.WriteLine(hashtable.ContainsKey("1"));
            Console.WriteLine(hashtable.Contains(3));

            Console.WriteLine("Hashtable");
            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            
            ArrayList arr = new ArrayList(hashtable.Keys);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            
        }
        static void onSortedListCall()
        {
            SortedList sortListNotDifine = new SortedList();
            SortedList<int, string> sortList = new SortedList<int, string>();
            sortList.Add(1, "one");
            sortList.Add(3, "two");
            sortList.Add(2, "three");
            sortList.Add(4, "four");
            sortList.Add(5, null);
            sortList.Add(11, null);



            sortList[1] = "ten";//Item
            Console.WriteLine("size: "+sortList.Count);//COUNT

            //methods

            Console.WriteLine("SortedListDefine");
            foreach (KeyValuePair<int, string> item in sortList)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            string value;
            if (sortList.TryGetValue(2,out value))
            {
                Console.WriteLine("2 key is = " + value);
            }

            Console.WriteLine("index of key 1:"+sortList.IndexOfKey(1));
            
            Console.WriteLine("index of value two: "+sortList.IndexOfValue("two"));

            Console.WriteLine("contains one = " + sortList.ContainsValue("two"));

            Console.WriteLine("contains 1 = " + sortList.ContainsKey(1));

            Console.WriteLine("contains  = " + sortList.Contains(new KeyValuePair<int, string>(1,"ten")));

           
            sortListNotDifine.Add("b", new Rectangle(3, 5));
            sortListNotDifine.Add("a", "c");

            Console.WriteLine("SortedListNotDefine");
            foreach (DictionaryEntry item in sortListNotDifine)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }

        static void onDicCall()
        {
            Dictionary<float,int> dic=new Dictionary<float,int>();
            dic.Add(1, 2);
            dic.Add(3, 4);
            Hashtable ha = new Hashtable(dic);
            foreach (var item in dic)
            {
                Console.WriteLine("key"+item.Key + " " + item.Value);
            }
            foreach (KeyValuePair<float, int> item in dic)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }
    }
}
