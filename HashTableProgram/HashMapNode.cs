using System;
using System.Collections.Generic;
using System.Text;

namespace HashTableProgram
{
    class HashMapNode<K, V>
    {
        public int size;
        public LinkedList<HashKeyValue<K, V>>[] items;
        public class HashKeyValue<K, V>
        {
            public K Key { get; set; }
            public V Value { get; set; }
        }

        public HashMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<HashKeyValue<K, V>>[size];
        }
    
        public int GetArrayIndex(K inputkey)
        {
            int index = inputkey.GetHashCode() % size;
            return index;
        }

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
        public void Add(K key, V value)
        {
            int position = GetArrayIndex(key);
            LinkedList<HashKeyValue<K, V>> hashkeyvalue = GetLL(position);
            HashKeyValue<K, V> item = new HashKeyValue<K, V> { Key = key, Value = value };
            hashkeyvalue.AddLast(item);
        }
    }
}
