using System;
namespace Project1
{
    public class MergesorterInt
    {
        public static void MergesortInt(int[] nums)
        {


            int[] work = new int[nums.Length];
            copy(nums, work);



        }

        private static void copy(int[] nums, int[] work)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                work[i] = nums[i];
            }
        }

        public static void mergeInt(int[] work, int low, int high, int[] nums)
        {
            if (low - high <= 1)
                return;
            int midpoint = (high + low) / 2;



            mergeInt(work, low, midpoint, nums);
            mergeInt(work, midpoint, high, nums);

            Merge(work, low, midpoint, high, nums);

        }



        static void Merge(int[] work, int low, int midpoint, int high, int[] nums)
        {
            int i = low, j = midpoint;

            // While there are elements in the left or right runs...
            for (int k = low; k < high; k++)
            {
                // If left run head exists and is <= existing right run head.
                if (i < midpoint && (j >= high || nums[i] <= nums[j]))
                {
                    work[k] = nums[i];
                    i = i + 1;
                }
                else
                {
                    work[k] = nums[j];
                    j = j + 1;
                }
                
            }
        }
    }
}
    