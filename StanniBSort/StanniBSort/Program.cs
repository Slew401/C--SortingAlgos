using System; 

namespace BubbleSort;

public class BubbleSort
{
    public static void Main()
    {
        int[] arr = new int[]{ 112,13,124,1,3 };
        BubSort(arr);
        //List<int> list = new() { 1,3,5,7,9};
        //List<int> list2 = new() { 2,4,6,8,10 };
        List<int> list = new() { 1, 2, 3, 4, 5 ,6 ,7};
        List<int> list2 = new() { 6, 7, 8, 9, 10 ,12,15};

        var mergedList = MergeMethod(list, list2);
        foreach (int i in arr)
        {
            Console.Write($"{i} ");
        }

        mergedList.ForEach(x => Console.Write($"{x} "));


    }

    private static List<int> MergeMethod(List<int> list, List<int> list2)
    {
        List<int> result = new();
        int i = 0;
        int j = 0;

        while (i < list.Count && j < list.Count)
        {
            if (list[i] < list2[j])
            {
                result.Add(list[i++]);
            }
            else
            {
                result.Add(list2[j++]);
            }
        }

        while(j < list2.Count)
            result.Add(list2[j++]);
        
        while(i < list.Count)
            result.Add(list[i++]);
        
        return result; 
    }

    public static void BubSort(int[] array)
    {
        int temp = 0;
        bool swapped = false;
        for(int i = 0; i < array.Length; i++)
        {
            swapped = false;
            for(int j = i + 1; j < array.Length; j++)
            {
                if(array[i] > array[j])
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    swapped = true;
                }
            }
            if (swapped == false) return;
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
