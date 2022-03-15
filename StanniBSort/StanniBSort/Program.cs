using System; 

namespace BubbleSort;

public class BubbleSort
{
    public static void Main()
    {
        int[] arr = new int[]{ 5,4,3,2,1 };
        BubSort(arr);
        List<int> list = new() { 1,3,5,7,9};
        List<int> list2 = new() { 2,4,6,8,10 };

        var mergedList = mergeMethod(list, list2);
        //foreach(int i in arr)
        //{
        //    Console.WriteLine(i);
        //}

        mergedList.ForEach(x => Console.Write($"{x} "));


    }

    private static List<int> mergeMethod(List<int> list, List<int> list2)
    {
        List<int> result = new();

        foreach(int i in list)
        {
            result.Add(i);
        }

        foreach(int item in list2)
        {
            result.Add(item);
        }

        BubSort(result);

        return result; 
    }

    public static void BubSort(int[] array)
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

    public static void BubSort(List<int> array)
    {
        int temp = 0;

        for (int i = 0; i < array.Count; i++)
        {
            for (int j = i + 1; j < array.Count; j++)
            {
                if (array[i] > array[j])
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
    }

}
    //public static List<int> Bub