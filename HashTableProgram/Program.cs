using System;

namespace HashTableProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome HashTable Program");

            int keycount = 0;
            string Para = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] Words = Para.Split(" ");
            int[] freqency = new int[Words.Length];

            HashMapNode<int, string> hashkv = new HashMapNode<int, string>(Words.Length);
            //Add() method to add key,value
            foreach(string i in Words)
            {
                hashkv.Add(keycount, i);
                keycount++;
            }           

            //Logic to find the Frequency
            int visited = -1;
            for(int i = 0;i<Words.Length;i++)
            {
                int count = 1;
                for(int j=i+1;j< Words.Length;j++)
                {
                    if(Words[i] == Words[j])
                    {
                        count++;
                        freqency[j] = visited;
                    }
                }
                if(freqency[i] != visited)
                {
                    freqency[i] = count;
                }
            }
            //Print the frequency
            for (int i = 0; i < Words.Length; i++)
            {
                if(freqency[i] != visited)
                {
                    Console.WriteLine(" Frequency of "+Words[i]+" is "+freqency[i]);
                }
            }

            //Remove() method to remove the the key-value pair
            hashkv.Remove(17);
            //Print() method to print all the key and values
            hashkv.Print();
            //Get() method to get the value for the given Key
            string value = hashkv.Get(5);
            Console.WriteLine("5th position Value is : " + value);
        }
    }
}
