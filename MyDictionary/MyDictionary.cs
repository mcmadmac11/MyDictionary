using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{


    public class MyDictionary
    {
        public List<object> GetTuple()
        { 

        var tuple2 = Tuple.Create("Dan", 12345);
        Console.WriteLine("{0}: {1}", tuple2.Item1, tuple2.Item2);
         List<object> myDictionaryList = new List<object>();
            myDictionaryList.Add(tuple2);
            Console.WriteLine(myDictionaryList[0]);
            return myDictionaryList;
        
        }
        //public List<Type> KeyValueList = new List<Type>();

        //public List<Type> keyValueList
        //{
        //    get { return KeyValueList; }
        //    set { KeyValueList = value; }
        }


        //public string[] Key;

        //public string[] key
        //{
        //    get { return key; }
        //    set { key = value; }
        //}

        


        //public ArrayList KvArray;
        //public ArrayList kvArray
        //{
        //    get { return KvArray; }
        //    set { KvArray = value; }
        //}




        //Dictionary<string, int> myDictionary = new Dictionary<string, int>();     


    







}
