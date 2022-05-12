using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        public static long factorial (int n)
        {
            if (n == 1)
            {
                return 1;
            }

            else

                return n * factorial(n - 1);
        }
        static void Main(string[] args)
        {
            string a = "aaabbbb";
            string rev = "kosasabri";
            int[] skaiciai = new int[] { 0, 2, 2, 3, 0, 15, 4, 4, 3, 9, 0};
            char paieska = 'a';
            int count = 0;
            bool anagram = false;

            char[] anagram1 = a.ToCharArray();
            char[] anagram2 = rev.ToCharArray();

            Console.WriteLine(factorial(9));

            LinkedList<int> ll = new LinkedList<int>();

            ll.AddLast(1);
            ll.AddLast(2);
            ll.AddLast(3);
            LinkedList<int> ll2 = new LinkedList<int>();

            while (ll.Count > 0)
            {
                LinkedListNode<int> mark1 = ll.First;
                ll.RemoveFirst();
                ll2.AddFirst(mark1);
                
            }

            foreach (var item in ll2)
            {
                Console.WriteLine(item);
            }



            /*
            for (int i = 0; i < skaiciai.Length/2; i++)
            {
                int tmp = skaiciai[i];
                skaiciai[i] = skaiciai[skaiciai.Length - i - 1];
                skaiciai[skaiciai.Length - i - 1] = tmp;
            }

            for (int i = 0; i < skaiciai.Length; i++)
            {
                Console.Write(skaiciai[i] + " ");
            }

            
            for (int i = 1; i < skaiciai.Length; i++)
            {
                int j = i;
                while (j > 0 && skaiciai[j-1] < skaiciai[j])
                {
                    int temp = skaiciai[j];
                    skaiciai[j] = skaiciai[j - 1];
                    skaiciai[j - 1] = temp;
                    j--;
                    Console.WriteLine();
                    for (int k = 0; k < skaiciai.Length; k++)
                    {
                        Console.Write(skaiciai[k] + " ");
                    }
                }
            }

            
            for (int i = 0; i < skaiciai.Length; i++)
            {
                Console.WriteLine(skaiciai[i]);
            }
            
            for (int i = 0; i < skaiciai.Length; i++)
            {
                for (int j = 0; j < skaiciai.Length-i-1; j++)
                {
                    if (skaiciai[j] < skaiciai[j+1])
                    {
                        int temp = skaiciai[j];
                        skaiciai[j] = skaiciai[j+1];
                        skaiciai[j+1] = temp;
                    }
                }
            }
            
            
            for (int i = 0; i < skaiciai.Length-1; i++)
            {
                for (int j = i+1; j < skaiciai.Length; j++)
                {
                    if (skaiciai[i] == skaiciai[j])
                    {
                        Console.WriteLine("{0}, pozicija {1}, ir {2}, pozicija {3}, sutampa.", skaiciai[i], i, skaiciai[j], j);
                    }
                }
            }

            
            char[] balses = new char[]{ 'a', 'e', 'i', 'u', 'o'};
            int balCount = 0;
            int priebCount = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (balses.Contains(a[i]))
                {
                    balCount++;
                }
                else priebCount++;
            }
            Console.WriteLine(balCount +" " + priebCount);

            if (a.Length != rev.Length)
            {
                Console.WriteLine(a + " nera anagrama su" + rev);
            }
            else
            {
                Array.Sort<char>(anagram1);
                Array.Sort<char>(anagram2);

                anagram = anagram1.SequenceEqual<char>(anagram2);
                Console.WriteLine(anagram1);
                Console.WriteLine(anagram2);
                Console.WriteLine(anagram);
            }

            if (anagram)
            {
                Console.WriteLine(new string(anagram1) + " yra anagrama su " + new string(anagram2));
            }
            else Console.WriteLine(new string(anagram1) + " nera anagrama su " + new string(anagram2));

            for (int i = a.Length-1; i >= 0; i--)
            {
                rev += a[i];
            }

            if (a.Equals(rev))
            {
                Console.WriteLine("palindromai");
            }
            else
            {
                Console.WriteLine("ne palindromai");
            }

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == paieska)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            */

        }
    }
}
