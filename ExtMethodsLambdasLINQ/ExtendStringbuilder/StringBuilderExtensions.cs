using System;
using System.Text;

public static class StringBuilderExtensions
{
    public static StringBuilder Substring(this StringBuilder sb, int ind, int len)
    {
        if (ind < 0 || ind >= sb.Length)
        {
            throw new IndexOutOfRangeException();
        }

        if (ind + len > sb.Length)
        {
            len = sb.Length - ind;
        }

        StringBuilder result = new StringBuilder(len);

        for (int i = 0; i < len; i++, ind++)
        {
            result.Append(sb[ind]);
        }

        return result;
    }

    public static StringBuilder Substring(this StringBuilder sb, int ind)
    {
        if (ind < 0 || ind >= sb.Length)
        {
            throw new IndexOutOfRangeException();
        }

        StringBuilder result = new StringBuilder();
        int count = sb.Length - ind;

        for (int i = 0; i < count; i++)
        {
            result.Append(sb[ind++]);
        }

        return result;
    }
}