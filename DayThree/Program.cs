using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayThree
{
  internal class Program
  {
    static void Main(string[] args)
    {
      /*Question One :  Largest Perimeter Triangle
       Descripton:Given an integer array nums, return the largest perimeter of a triangle with a non-zero area, formed from three of these lengths. If it is impossible to form any triangle of a non-zero area, return 0.

        Example 1:

        Input: nums = [2,1,2]
        Output: 5

        Example 2:

        Input: nums = [1,2,1]
        Output: 0
        */

      /*Question Two : Find Nearest Point That Has the Same X or Y Coordinate 
       Description : You are given two integers, x and y, which represent your current location on a Cartesian grid: (x, y). You are also given an array points where each points[i] = [ai, bi] represents that a point exists at (ai, bi). A point is valid if it shares the same x-coordinate or the same y-coordinate as your location.

        Return the index (0-indexed) of the valid point with the smallest Manhattan distance from your current location. If there are multiple, return the valid point with the smallest index. If there are no valid points, return -1.

          The Manhattan distance between two points (x1, y1) and (x2, y2) is abs(x1 - x2) + abs(y1 - y2).

 

          Example 1:

          Input: x = 3, y = 4, points = [[1,2],[3,1],[2,4],[2,3],[4,4]]
          Output: 2
          Explanation: Of all the points, only [3,1], [2,4] and [4,4] are valid. Of the valid points, [2,4] and [4,4] have the smallest Manhattan distance from your current location, with a distance of 1. [2,4] has the smallest index, so return 2.

          Example 2:

          Input: x = 3, y = 4, points = [[3,4]]
          Output: 0
          Explanation: The answer is allowed to be on the same location as your current location.

          Example 3:

          Input: x = 3, y = 4, points = [[2,3]]
          Output: -1
          Explanation: There are no valid points.*/
    }

    /*Question One Solution*/
    public int LargestPerimeter(int[] nums)
    {
      Array.Sort(nums);

      for (int i = nums.Length - 3; i >= 0; --i)
      {
        if (nums[i] + nums[i + 1] > nums[i + 2])
          return nums[i] + nums[i + 1] + nums[i + 2];
      }
      return 0;

    }
    /*Question Two Solution*/
    public int NearestValidPoint(int x, int y, int[][] points)
    {
      int minDistance = Int32.MaxValue;
      int res = -1;

      for (int i = 0; i < points.Length; i++)
      {
        // valid points
        if (points[i][0] == x || points[i][1] == y)
        {
          int distance = Math.Abs(x - points[i][0]) + Math.Abs(y - points[i][1]);
          if (distance < minDistance)
          {
            res = i;
            minDistance = distance;
          }
        }
      }

      return res;
    }
  }
}
