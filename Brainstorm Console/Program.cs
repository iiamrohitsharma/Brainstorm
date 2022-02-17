using Brainstorm_Console.Challenges;
using System;
using System.Text;

namespace Brainstorm_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 7, 11, 15, 30, 25 };
            var myselt = TwoSum.TwoSumNumb(nums, 45);

            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in myselt)
            {

                stringBuilder = stringBuilder.AppendLine(item.ToString());
            }

            Console.WriteLine(stringBuilder);
        }
    }
}
