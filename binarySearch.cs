public static class Utilities
{

    public static int BinarySearch(int target, int[] nums)
    {
        int firstIndex = 0;
        int lastIndex = nums.Length - 1;
        int middleIndex = (int)(lastIndex) /2;

        while(firstIndex <= lastIndex)
        {
            if (nums[middleIndex] < target)
            {
                firstIndex = middleIndex + 1;
                middleIndex = (int)(firstIndex + lastIndex) /2;
            }

            else if (nums[middleIndex] > target)
            {
                lastIndex = middleIndex - 1;
                middleIndex = (int)(firstIndex + lastIndex) /2;
            }
            
            else
            {
                return middleIndex;
            }


        }
        return -1;
    }
}