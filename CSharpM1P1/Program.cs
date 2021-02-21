using System;

namespace CSharpM1P1
{
    class Program
    {
        static void Main(string[] args)
        {
           for(int i=1; i<=100; i++){
            if(i % 3 == 0){
                if(i % 5 == 0){
                    Console.Write("FizzBuzz, ");
                    }
                else {Console.Write("Fizz, ");}
                }
            else {
                if (i % 5 == 0){
                    Console.Write("Buzz, ");
                    }
                else{
                    Console.Write("{0}, ", i);
                    }
                }
            }
           Console.Read();
        }
    }
}
