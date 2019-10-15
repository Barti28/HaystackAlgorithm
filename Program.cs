using System;

namespace Haystack
{
    class Program
    {
       

      public static void Main(string[] args)
        {
            Console.WriteLine("Put the heystack:");
            string haystack = Console.ReadLine(); //a variable that take the haystack input from user, as string
            Console.WriteLine("Put the needle:");
            string needle = Console.ReadLine();//a variable that take the needle input from user, as string
            Console.WriteLine("Put the threshold:");
            string threshold = Console.ReadLine();//a variable that take the threshold input from user, as string
            int InputThreshold;//this variable will hold the converting threshold variable in int
            int.TryParse(threshold, out InputThreshold);
            char[] needl = needle.ToCharArray();//convert needle in char
            char[] hay = haystack.ToCharArray();//convert haystack in char 
            int found = 0;// will hold the needle off set
            int index = 0;//a variable that will go in the position of needl characters
            int print = 0;//a variable that will hold the position of haystack 
            int chMatched = 0;// if a charachter will match from haystack to needle this variable will be iterated

            for (int i = 0; i < hay.Length; i++)
            {

                if (index >= needle.Length || chMatched == 0)
                    index = 0;

                if (hay[i] == needl[index])
                {
                    chMatched++;
                }

                else
                {
                    if (chMatched != 0)
                    {
                        if (chMatched < 3)
                        {
                            chMatched = 0;
                            i--;
                        }
                        else
                        {
                            Console.WriteLine("sequence of length: " + chMatched + " haystack: " + print + " needle offset: " + found);
                            found++;
                            i = i - 1;
                            chMatched = 0;
                        }
                    }
                    else
                    {
                        for (index = 0; index < needle.Length; index++)
                        {
                            if (hay[i] == needl[index])
                            {
                                chMatched++;
                                break;
                            }
                        }
                    }
                }

                if (chMatched == InputThreshold)
                {
                    print = i - (chMatched - 1);
                }
                index++;
            }
            
        }
        
       
        }
   
}
