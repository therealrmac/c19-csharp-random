using System;
using System.Collections.Generic;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
           Random rand= new Random();

           List<int> num= new List<int>();
     
           for(var i=0; i<20; i++){
               num.Add(rand.Next(1,50));
           }         
          

          foreach(var x in num){
              double y = Math.Pow(x,2);
              //Console.WriteLine(y);
              if(y % 2 ==0){
                  Console.WriteLine(y);
              }
          }
        }
    }
}
