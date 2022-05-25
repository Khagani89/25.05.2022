using System;

namespace Homework._25._05._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Verilmis adlar siyahisinda (string array) nece adin uzunlugunun 5-den boyuk oldugunu tapan proqram

            string[] namelist = { "Ali","Xaliq","Xaqani","Mehemmed" };
            int count = 0;
            {
                for (int i = 0; i < namelist.Length; i++) 
                {
                    for(int j = 0; j < namelist[i].Length; j++)
                    {
                        if(j > 5)
                        {
                            count++;
                        }
                    }
                }  

            }Console.WriteLine(count);
        }
    }
}
