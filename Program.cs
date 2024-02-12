
using DataStructures;

class Program
{
    static int Menu()
    {
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Option\t|\tFunction");
        Console.WriteLine("---------------------------------");
        Console.WriteLine("[1]\t|\tSequential Search");
        Console.WriteLine("[2]\t|\tBinary Search");
        Console.WriteLine("[3]\t|\tBubble Sort");
        Console.WriteLine("[4]\t|\tInsertion Sort");
        Console.WriteLine("[5]\t|\tMerge Sort");
        Console.WriteLine("[6]\t|\tQuick Sort");
        Console.WriteLine("[7]\t|\tHeap Sort");
        Console.WriteLine("[0]\t|\tQuit");
        Console.WriteLine("---------------------------------");

        var strOption = Console.ReadLine();
        try
        {
            int option = Convert.ToInt32(strOption);
            return option;
        }
        catch (Exception)
        {
            Console.WriteLine("Error during type conversion. Please send only numbers");
            return -1;
        }
    }
    private static void Main(string[] args)
    {
        int option, index, target = -1;
        Sorter sorter = new();

        do
        {
            option = Menu();

            if (option == 1 || option == 2)
            {
                Console.WriteLine("Target: ");
                var strTarget = Console.ReadLine();
                target = Convert.ToInt32(strTarget);
            }

            switch (option)
            {
                case 1:
                    index = sorter.SequentialSearch(target);
                    if (index != -1)
                        Console.WriteLine($"The target {target} has index {index}");
                    else
                        Console.WriteLine($"The target {target} isn't on the list");
                    break;
                case 2:
                    index = sorter.BinarySearch(target);
                    if (index != -1)
                        Console.WriteLine($"The target {target} has index {index}");
                    else
                        Console.WriteLine($"The target {target} isn't on the list");
                    break;
                case 3:
                    sorter.BubbleSort();
                    break;
                case 4:
                    sorter.InsertionSort();
                    break;
                case 5:
                    var sortedArray = sorter.MergeSort(sorter.GenerateArray(10, randomize: true));
                    sorter.ShowArray(sortedArray, "Sorted Array");
                    break;
                case 6:
                    var randomArray = sorter.GenerateArray(10, randomize: true);
                    sorter.ShowArray(randomArray, "Unsorted Array");
                    sorter.QuickSort(randomArray, 0, randomArray.Length - 1);
                    sorter.ShowArray(randomArray, "Sorted Array");
                    break;
                case 7:
                    randomArray = sorter.GenerateArray(10, randomize: true);
                    sorter.ShowArray(randomArray, "Unsorted Array");
                    sorter.HeapSort(randomArray);
                    sorter.ShowArray(randomArray, "Sorted Array");
                    break;
                case 0:
                    Console.WriteLine("Bye...");
                    break;
                default:
                    Console.WriteLine("This option does not exist.");
                    break;
            }
        } while (option != 0);
    }
}
