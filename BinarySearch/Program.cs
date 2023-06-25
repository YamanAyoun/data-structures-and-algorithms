namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 8, 16, 23, 42 };

            int key = 4;
            int result = BinarySearch(arr, key);

            Console.WriteLine(result);
        }
        public static int BinarySearch(int[] arr, int key)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (arr[mid] == key)
                    return mid;

                else if (arr[mid] < key)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1;
        }

    }
}