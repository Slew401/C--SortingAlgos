using System; 

namespace BubbleSort;

public class BubbleSort
{
    public static void Main()
    {
        int[] arr = new int[]{ 12, 32, 31, 45, 15, 96, 70 };
        BSort(arr);
        foreach(int i in arr)
        {
            Console.WriteLine(i);
        }
    }


    // Intiution behind BSort is simple for each value
    public static void BSort(int[] array)
    {
        int temp = 0;

        for(int i = 0; i < array.Length; i++)
        {
            for(int j = i + 1; j < array.Length; j++)
            {
                if(array[i] > array[j])
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
    }
}
