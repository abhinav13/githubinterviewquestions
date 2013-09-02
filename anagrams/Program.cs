using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace anagrams
{
    class Program
    {


        private static bool ContainsAll(Hashtable myhash, String checkword)
        {
            if (checkword != null)
            {
                foreach (char c in checkword)
                {
                    if (myhash.ContainsKey(c))
                    {
                        myhash[c] = 0;
                    }
                }

                foreach (char c in myhash.Keys)
                {
                    if ((int)myhash[c] != 0)
                        return false;
                }
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Hashtable myhash = new Hashtable();
            List<String> words = new List<String>{"tree","evil","live","god", "dog", "ivel"};
            List<String> mywords = new List<String>(words);

            for (int i = 0; i < mywords.Count(); i++ )
            {
                String s = mywords[i];
                //Create hashtable
                initHashtable(myhash, s);
                //now iterate to the end of the list
                for (int j = i + 1; j < mywords.Count(); j++)
                {
                    if(ContainsAll(myhash,mywords[j]))
                    {
                        Console.WriteLine("Anagram of {0} is {1}",s,mywords[j]);
                        mywords.RemoveAt(j);
                    }
                    //Re init it the word we are checking.

                    initHashtable(myhash, s);
                }

            }
            Console.ReadKey();

        }

        private static void initHashtable(Hashtable myhash, String s)
        {
            myhash.Clear();
            foreach (char c in s)
            {
                myhash[c] = 1;
            }
        }
    }
}
