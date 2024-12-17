namespace Assignment_7_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array:");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nUnsorted Array:");
            foreach (var num in arr)
                Console.Write(num + " ");

            ShellSortProgram.ShellSort(arr, size);

            Console.WriteLine("\n\nSorted Array:");
            foreach (var num in arr)
                Console.Write(num + " ");

            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadKey();
        }
    }

    class ShellSortProgram
    {
        public static void ShellSort(int[] arr, int n)
        {
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = arr[i];
                    int j;

                    for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                    {
                        arr[j] = arr[j - gap];
                    }

                    arr[j] = temp;
                }
            }
        }
    }
}

               



