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

            HashMapNode<int, string> hashkv = new HashMapNode<int, string>(Words.Length);

            foreach(string i in Words)
            {
                hashkv.Add(keycount, i);
                keycount++;
            }           
            hashkv.Print();

            hashkv.Remove(17);
           
        }
    }
}
