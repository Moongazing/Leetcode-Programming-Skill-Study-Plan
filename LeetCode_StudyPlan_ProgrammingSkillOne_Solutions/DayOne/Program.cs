using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOne
{
  internal class Program
  {
    static void Main(string[] args)
    {

      /*Question One:  Count Odd Numbers in an Interval Range 
       Desc:Given two non-negative integers low and high. Return the count of odd numbers between low and high (inclusive).

       Example 1:

       Input: low = 3, high = 7
       Output: 3
       Explanation: The odd numbers between 3 and 7 are [3,5,7].

       Example 2:

       Input: low = 8, high = 10
       Output: 1
       Explanation: The odd numbers between 8 and 10 are [9].*/

      /*
       Question Two : Average Salary Excluding the Minimum and Maximum Salary
        Descripton:You are given an array of unique integers salary where salary[i] is the salary of the ith employee.

        Return the average salary of employees excluding the minimum and maximum salary. Answers within 10-5 of the actual answer will be accepted.

        Example 1:

        Input: salary = [4000,3000,1000,2000]
        Output: 2500.00000
        Explanation: Minimum salary and maximum salary are 1000 and 4000 respectively.
        Average salary excluding minimum and maximum salary is (2000+3000) / 2 = 2500

        Example 2:

        Input: salary = [1000,2000,3000]
        Output: 2000.00000
        Explanation: Minimum salary and maximum salary are 1000 and 3000 respectively.
        Average salary excluding minimum and maximum salary is (2000) / 1 = 2000

       */
    }
    /*Question One Solution*/
    public int CountOdds(int lower, int higher)
    {
      int result = (higher - lower) / 2;

      // if either higher or lower is odd
      if (higher % 2 != 0 || lower % 2 != 0)
        result++;

      return result;
    }
    /*Question Two Solution*/
    public double Average(int[] salary)
    {
      int i, max, min, n;
      n = salary.Length;

      max = salary[0];
      min = salary[0];

      for (i = 1; i < n; i++)
      {
        if (salary[i] > max)
        {
          max = salary[i];
        }
        if (salary[i] < min)
        {
          min = salary[i];
        }
      }
      salary = salary.Where(val => val != max).ToArray();
      salary = salary.Where(val => val != min).ToArray();

      double avg = Queryable.Average(salary.AsQueryable());
      return avg;
    }
  }
}
