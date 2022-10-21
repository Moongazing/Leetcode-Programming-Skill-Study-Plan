using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTwo
{
  internal class Program
  {
    static void Main(string[] args)
    {
      /*Question One:Write a function that takes an unsigned integer and returns the number of '1' bits it has (also known as the Hamming weight).

      Note:

      Note that in some languages, such as Java, there is no unsigned integer type. In this case, the input will be given as a signed integer type. It should not affect
      your implementation, as the integer's internal binary representation is the same, whether it is signed or unsigned.
      In Java, the compiler represents the signed integers using 2's complement notation. Therefore, in Example 3, the input represents the signed integer. -3.
      */


      /*Question Two : Subtract the Product and Sum of Digits of an Integer

        Given an integer number n, return the difference between the product of its digits and the sum of its digits. */
    }
    /*Question One Solution*/
     public int HammingWeight(uint n)
    {
      int count = 0;
      while (n != 0)
      {
        count++;
        n &= n - 1;
      }
      return count;
    }
    /*Question Two Solution*/
    public int SubtractProductAndSum(int n)
    {
      int sum = 0;
      int product = 1;
      while (n > 0)
      {
        sum += n % 10;
        product *= n % 10;
        n /= 10;
      }
      return product - sum;
    }
  }
}
