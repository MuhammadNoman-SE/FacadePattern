using System;
using BallOfMud.Services;

namespace BallOfMud
{
    class Program
    {
        static void Main(string[] args)
        {
            BigClassFacade bigClass = new BigClassFacade();
            
          
            bigClass.IncrementBy(50);
            
            bigClass.DecrementBy(30);

            Console.WriteLine($"Final Number : {bigClass.GetCurrent()}");
            Console.ReadLine();

        }
    }
}