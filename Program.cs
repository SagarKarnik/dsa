namespace dsa
{
    public class searching
    {




        public static void Main(String[] args)
        {            
            Console.WriteLine("The array with elements ");            
            int[] arr = { 1, 23, 45, 56, 75, 79, 83, 87, 91 };
            int srch = 83;
            Console.WriteLine("[ ");
            foreach (int i in arr) {
                Console.Write(i + " ");
            }
            Console.Write("]");
            Console.WriteLine("Find element:- " + srch);

            Console.WriteLine("binary search is starting");
            var result = binarysearch(arr, srch, 0, arr.Length - 1);
            if (result)
            {
                Console.WriteLine("Correct results.");
            }
        }


        public static bool binarysearch(int[] arr, int srch, int low, int high) {

            int mid = (high - low) / 2 + low;

            if (arr[mid] == srch)
                return true;
            else if (arr[mid] < srch)
            {
                low = mid + 1;
                binarysearch(arr, srch, low, high);
            }
            else
            {
                high = mid - 1;
                binarysearch(arr, srch, low, high);
            }

            return false;
        }

    }
}