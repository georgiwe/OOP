using System;
using System.Collections.Generic;
using System.Linq;

public static class IEnumerableExtensions
{
    public static double Average<T>(this IEnumerable<T> elements)
    {
        Type typeOfElements = typeof(T);

        CheckEligibilty(typeOfElements);

        double result = 0;
        double sum = 0;
        double count = 0;

        foreach (var element in elements)
        {
            sum += (dynamic)element;
            count++;
        }

        result = sum / count;

        return result;
    }

    public static T Sum<T>(this IEnumerable<T> elements)
    {
        Type typeOfElements = typeof(T);

        CheckEligibilty(typeOfElements);

        dynamic result = 0;

        foreach (var element in elements)
        {
            result += element;
        }

        return (T)result;
    }

    public static T Product<T>(this IEnumerable<T> elements)
    {
        Type typeOfElements = typeof(T);

        CheckEligibilty(typeOfElements);

        dynamic result = 1;

        foreach (var element in elements)
        {
            result *= element;
        }

        return (T)result;
    }

    public static T Min<T>(this IEnumerable<T> elements) where T : IComparable
    {
        T min = elements.FirstOrDefault();

        foreach (var element in elements)
        {
            if (min == null || min.CompareTo(element) > 0)
            {
                min = element;
            }
        }

        return min;
    }

    public static T Max<T>(this IEnumerable<T> elements) where T : IComparable
    {
        T max = elements.FirstOrDefault();

        foreach (var element in elements)
        {
            if (max == null || max.CompareTo(element) < 0)
            {
                max = element;
            }
        }

        return max;
    }

    private static void CheckEligibilty(Type type)
    {
        if (type.IsPrimitive == false ||
            type == typeof(string) ||
            type == typeof(DateTime) ||
            type == typeof(bool) ||
            type == typeof(char))
        {
            throw new ArgumentException("The specified type is ineligible.");
        }
    }
}