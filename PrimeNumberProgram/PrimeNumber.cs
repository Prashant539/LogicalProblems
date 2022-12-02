using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberProgram
{
    public class PrimeNumber
    {
        public void CheckPrime()
        {

            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            bool IsPrime = true;

            for (int i = 2; i < num / 2; i++)
            {
                if (num % i == 0)
                {
                    IsPrime = false;
                    Console.WriteLine("Is not prime");
                    break;
                }
            }
            if (IsPrime)
            {
                Console.WriteLine("Prime Number");
            }

        }
    }
}
    

