using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>Define some basics mathematics operations</summary>
    public class Operations
    {
        /// <summary>Search the max integer in a list of integers.</summary>
        /// <param name="nums">The list of int</param>
        /// <returns>The max int in the list or 0 if nums is empty</returns>
        public static int Max(List<int> nums)
        {
            try
            {
                int max = nums[0];

                foreach (var element in nums)
                {
                    if (max < element)
                        max = element;
                }

                return max;
            }
            catch (Exception ex)
            {
                if (ex is ArgumentOutOfRangeException || ex is NullReferenceException)
                    return 0;

                throw;
            }
        }
    }
}
