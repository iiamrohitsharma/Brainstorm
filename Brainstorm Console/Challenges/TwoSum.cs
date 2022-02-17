using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brainstorm_Console.Challenges
{
    public class TwoSum
    {
        public static int[] TwoSumNumb(int[] nums, int target)
        {

            int[] myArray = new int[2];
            int k = 0;

            for (int i = 0; i <= nums.Length -1 ; i++)
            {
                for (int j = 1; j <= nums.Length - 1; j++)
                {
                    if (nums[i] + nums[j] == target && i != j)
                    {
                        myArray[k] = i;
                        ++k;
                        myArray[k] = j;

                        return myArray;
                    }
                }

            }

            return myArray;
        }
    }

    //static void Main(string[] args)
    //{
    //    int[] nums = new int[] { 2, 7, 11, 15, 30, 25 };
    //    var myselt = TwoSum.TwoSumNumb(nums, 45);

    //    StringBuilder stringBuilder = new StringBuilder();
    //    foreach (var item in myselt)
    //    {

    //        stringBuilder = stringBuilder.AppendLine(item.ToString());
    //    }

    //    Console.WriteLine(stringBuilder);
    //}

}
