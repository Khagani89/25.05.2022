using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args) 
        {
        
        var cutededler = List(1,2,3,4,5,6,7,8,9);

         Console.WriteLine(cutededler);
            
        
        }

        static int List(int[] numbers)
        {
          
            int numbers2 = 0;
            {

                for (int i = 0; i < numbers.Length; i++) 
                {
                    if (numbers[i] % 2 == 0) ;
                    {
                   numbers2 = numbers[i];

                    }
                }
                return numbers2;    
                
                     
            }
          



        
        }
    }
}
