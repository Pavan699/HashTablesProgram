using System;

namespace HashTableProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome HashTable Program");
            HashMapNode<int, string> hashkv = new HashMapNode<int, string>(6);
            hashkv.Add(0, "To");
            hashkv.Add(1, "be");
            hashkv.Add(2, "or");
            hashkv.Add(3, "not");
            hashkv.Add(4, "to");
            hashkv.Add(5, "be");          

            string value1 = hashkv.Get(5);
            Console.WriteLine("5th Position Value is : "+value1);
           
            string value2 = hashkv.Get(3);
            Console.WriteLine("3rd Position Value is : " + value2);

            string value3 = hashkv.Get(0);
            Console.WriteLine("0th Position Value is : " + value3);
            hashkv.Print();

        }
    }
}
