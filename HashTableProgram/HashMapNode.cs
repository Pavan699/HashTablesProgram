using System;
using System.Collections.Generic;
using System.Text;

namespace HashTableProgram
{
    class HashMapNode<K, V>
    {
        //class instances
        public int size;
        public LinkedList<HashKeyValue<K, V>>[] items;
        //HashKeyValue class(Nested class)
        public class HashKeyValue<K, V>
        {
            public K Key { get; set; }
            public V Value { get; set; }
        }
        //constructor to assing the size and item(holds key,value)
        public HashMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<HashKeyValue<K, V>>[size];
        }
        /// <summary>
        /// GetArrayIndex() to find the index by getting hashcode through the inputkey 
        /// </summary>
        /// <param name="inputkey">to get the hashcode</param>
        /// <returns>index to assing the value</returns>
        public int GetArrayIndex(K inputkey)
        {
            int index = inputkey.GetHashCode() % size;
            return index;
        }
        /// <summary>
        /// GetLL() to assing the value at that perticular(calculated) index
        /// </summary>
        /// <param name="index">input form the GetArrayIndex() method</param>
        /// <returns>llist</returns>
        public LinkedList<HashKeyValue<K, V>> GetLL(int index)
        {
            LinkedList<HashKeyValue<K, V>> llist = items[index];
            if(llist == null)
            {
                llist = new LinkedList<HashKeyValue<K, V>>();
                items[index] = llist;
            }
            return llist;
        }
        /// <summary>
        /// Get() to get the value
        /// </summary>
        /// <param name="key">to check the key is present or not,if present return the value</param>
        /// <returns>value</returns>
        public V Get(K key)
        {
            int position = GetArrayIndex(key);
            LinkedList<HashKeyValue<K, V>> hashkeyvalue = GetLL(position);
            foreach(HashKeyValue<K, V> item in hashkeyvalue)
            {
                if(item.Key.Equals(key))
                {
                    return item.Value;
                }
            }
            return default(V);
        }
        /// <summary>
        /// Add() method to add the key-value
        /// </summary>
        /// <param name="key">to calculate hashcode</param>
        /// <param name="value">to set at index</param>
        public void Add(K key, V value)
        {
            int position = GetArrayIndex(key);
            LinkedList<HashKeyValue<K, V>> hashkeyvalue = GetLL(position);
            HashKeyValue<K, V> item = new HashKeyValue<K, V> { Key = key, Value = value };
            hashkeyvalue.AddLast(item);
        }
        /// <summary>
        /// Print() method to print the keys and it's values
        /// </summary>
        public void Print()
        {
            foreach (LinkedList<HashKeyValue<K, V>> i in items)
            {
                foreach (HashKeyValue<K, V> item in i)
                {
                    Console.WriteLine(item.Key + " : " + item.Value);
                }
            }
        }
        /// <summary>
        /// Remove() method to remove the value of entered key position  
        /// </summary>
        /// <param name="key">to check it is present or not, if present ,remove it</param>
        public void Remove(K key)
        {
            int position = GetArrayIndex(key);
            LinkedList<HashKeyValue<K, V>> hashkeyvalue = GetLL(position);
            bool check = false;
            HashKeyValue<K, V> tempitem = default(HashKeyValue<K, V>);
            foreach (HashKeyValue<K, V> item in hashkeyvalue)
            {
                if (item.Key.Equals(key))
                {
                    check = true;
                    tempitem = item;
                }
            }
            if (check)
            {
                hashkeyvalue.Remove(tempitem);
                Console.WriteLine("Removed {0} position. Value is : {1}", key, tempitem.Value);
            }
        }
    }
}
