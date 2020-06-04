using System;
using System.Collections.Generic;
using System.Linq;

namespace Codenation.Challenge
{
    public class Math
    {
        public static void main()
        {
            Fibbonacci();
        }
        public List<int> Fibonacci()
        {
             List<int> listFibonacci = new List<int>();

            listFibonacci.Add(0);
            listFibonacci.Add(1);
           
            for (int i = 2; i <= 350; i++) 
            { listFibonacci.Insert(i, listFibonacci.ElementAt(i - 1) + listFibonacci.ElementAt(i - 2)); 
                if (listFibonacci(i)>350){
                    i=351;
                    listFibonacci.RemoveAt(i);
                }
                printf(listFibonacci(i));
            }

            return listFibonacci;
        }
        public bool IsFibonacci(int numberToTest)
        {
           return Fibonacci().Contains(numberToTest);
        }
    }
}
