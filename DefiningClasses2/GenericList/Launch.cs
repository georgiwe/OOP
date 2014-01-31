using System;

public class Launch
{
    public static void Main()
    {                               // First is the capacity, the rest are the elements
        GenericList<int> list = new GenericList<int>(10, 4, 3, 2);

        // Add element to list
        list.Add(55);
        list.Add(-33);
        list.Add(11);

        // Remove element at index
        list.RemoveAt(2);

        // Insert element at index
        list.Insert(1, 99);

        // Printing the entire list with a ToString method.
        Console.WriteLine(list.ToString());

        // Clear the list
        list.Clear();

        // Test Adding and inserting after clearing
        Console.WriteLine(list.Count);
        list.Insert(0, 5);
        list.Insert(1, 55);

        list = new GenericList<int>(3, 1, 2, 3);
        list.Insert(1, 0);
        list.Add(0);

        // Test .IndexOf()
        int indOfZero = list.IndexOf(0, 2);

        // Test Min<T>() and Max<T>()
        list.Add(-4);
        int minValue = list.Min<int>();
        int maxValue = list.Max<int>();
    }
}