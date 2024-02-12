using System.Linq;

namespace DataStructures;
public class Sorter
{
    public int SequentialSearch(int target)
    {
        int[] array = GenerateArray(10);

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == target)
            {
                return i;
            }
        }

        return -1;
    }

    public int BinarySearch(int target)
    {
        int[] array = GenerateArray(10);
        int low = 0, high = array.Length, mid = (low + high) / 2;

        while (low <= high)
        {
            mid = (low + high) / 2;

            if (array[mid] == target)
                return mid;
            else if (target > array[mid])
                low = mid + 1;
            else
                high = mid - 1;
        }

        return -1;
    }

    public void BubbleSort()
    {
        int[] randomArray = GenerateArray(10, randomize: true);
        ShowArray(randomArray, title: "\nUnsorted Array");

        for (int i = 1; i < randomArray.Length; i++)
        {
            for (int j = 0; j < randomArray.Length - 1; j++)
            {
                if (randomArray[j] > randomArray[i])
                    (randomArray[j], randomArray[i]) = (randomArray[i], randomArray[j]);
            }
        }

        ShowArray(randomArray, title: "\nSorted Array");
    }

    public void InsertionSort()
    {
        int[] randomArray = GenerateArray(10, randomize: true);
        ShowArray(randomArray, title: "\nUnsorted Array");

        for (int i = 1; i < randomArray.Length - 1; i++)
        {
            int j = i;

            while (j > 0 && randomArray[j - 1] > randomArray[j])
            {
                (randomArray[j], randomArray[j - 1]) = (randomArray[j - 1], randomArray[j]);
                j--;
            }
        }

        ShowArray(randomArray, title: "\nSorted Array");
    }

    public int[] MergeSort(int[] randomArray)
    {

        if (randomArray.Length == 1)
            return randomArray;

        int[] firstPartialArray = randomArray.Take(randomArray.Length / 2).ToArray();
        int[] secondPartialArray = randomArray.Skip(randomArray.Length / 2).Take(randomArray.Length / 2).ToArray();

        firstPartialArray = MergeSort(firstPartialArray);
        secondPartialArray = MergeSort(secondPartialArray);

        return Merge(firstPartialArray, secondPartialArray);
    }

    private int[] Merge(int[] firstPartialArray, int[] secondPartialArray)
    {
        int[] sortedArray = [];

        while (firstPartialArray.Length > 0 && secondPartialArray.Length > 0)
        {
            if (firstPartialArray[0] > secondPartialArray[0])
            {
                sortedArray = [.. sortedArray, secondPartialArray[0]];
                secondPartialArray = secondPartialArray.Skip(1).ToArray();
            }
            else
            {
                sortedArray = [.. sortedArray, firstPartialArray[0]];
                firstPartialArray = firstPartialArray.Skip(1).ToArray();
            }
        }

        while (firstPartialArray.Length > 0)
        {
            sortedArray = [.. sortedArray, firstPartialArray[0]];
            firstPartialArray = firstPartialArray.Skip(1).ToArray();
        }

        while (secondPartialArray.Length > 0)
        {
            sortedArray = [.. sortedArray, secondPartialArray[0]];
            secondPartialArray = secondPartialArray.Skip(1).ToArray();
        }
        return sortedArray;
    }

    public void HeapSort(int[] randomArray)
    {
        for (int i = (randomArray.Length / 2) - 1; i >= 0 ; i--)
        {
            Heapify(randomArray, randomArray.Length, i);
        }

        for (int i = randomArray.Length - 1; i > 0; i--)
        {
            (randomArray[i], randomArray[0]) = (randomArray[0], randomArray[i]);
            Heapify(randomArray, i, 0);
        }
    }

    private void Heapify(int[] array,int heapSize, int index){
        int root = index;
        int left = (2 * index) + 1;
        int right = (2 * index) + 2;

        if(left < heapSize && array[left] > array[root])
            root = left;
        
        if(right < heapSize && array[right] > array[root])
            root = right;

        if(root != index){
            (array[root], array[index]) = (array[index], array[root]);
            Heapify(array, heapSize, root);
        }
    }

    public void QuickSort(int[] randomArray, int low, int high)
    {
        if (low < high)
        {
            var pivot = Partition(randomArray, low, high);
            QuickSort(randomArray, low, pivot - 1);
            QuickSort(randomArray, pivot + 1, high);
        }
    }

    private int Partition(int[] array, int low, int high)
    {
        var pivot = array[high];
        var i = low;

        for (int j = low; j < high; j++)
        {
            if (array[j] <= pivot)
            {
                (array[j], array[i]) = (array[i], array[j]);
                i++;
            }
        }

        (array[i], array[high]) = (array[high], array[i]);
        return i;
    }

    public int[] GenerateArray(int length, bool randomize = false)
    {
        int[] array = new int[length];

        if (randomize)
        {
            Random random = new();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(140);
            }

            return array;
        }

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i;
        }

        return array;
    }

    public void ShowArray(int[] array, string title = "Array")
    {
        Console.WriteLine(title);
        foreach (var item in array)
        {
            Console.Write($"[{item}]");
        }
        Console.WriteLine("\n");
    }

}
