public static class Recursions
{//might be missing some wrapper functions thou idk just trying to submit on time
    public static void Fill(this int[] arr) => Fill(arr, 0);
    private static int Fill(int[] arr, int i)
    {
        if (i >= arr.Length)
        {
            return 0;
        }
        if (int.TryParse(Console.ReadLine(), out int value))
        {
            return Fill(arr, i);
        }
        arr[i] = value;
        return Fill(arr, ++i);
    }
    public static void Print(this int[] arr)
    {
        int i = 0;
        if (i >= arr.Length)
        {
            return;
        }
        Console.WriteLine($"[{Print(arr, ++i)}");
    }
    private static string Print(int[] arr, int i)
    {
        if (i >= arr.Length)
        {
            return "]";
        }
        if (++i >= arr.Length)
        {
            return $"{arr[i]}{Print(arr, ++i)}";
        }
        return $"{arr[i]},{Print(arr, ++i)}";
    }
    public static int Sum(this int[] arr, int i)
    {
        if (i < 0)
        {
            return 0;
        }
        if (i >= arr.Length)
        {
            return Sum(arr, --i);
        }
        return arr[i] + Sum(arr, --i);
    }
    public static bool IsUp(this int[] arr, int i)
    {
        if (i < 0)
        {
            return true;
        }
        if (arr[--i] > arr[i])
        {
            return false;
        }
        return IsUp(arr, --i);
    }

    public static bool IsSorted(int[] arr, int i, int j)
    {
        if (i < 0)
        {
            return true;
        }
        if (i > j)
        {
            return IsSorted(arr, --i, j);
        }
        if (arr[--i] > arr[i])
        {
            return false;
        }
        return IsSorted(arr, --i, j);
    }
    public static bool IsArithmetic(this int[] arr, int i)
    {
        if (arr.Length <= 2)
        {
            return true;
        }
        return Arithmetic(arr, i);
    }
    private static bool Arithmetic(int[] arr, int i)
    {
        if (i < 2)
        {
            return true;
        }
        int d = arr[i] - arr[--i];
        i--;
        int diff = arr[i] - arr[--i];
        if (d == diff)
        {
            return Arithmetic(arr, i);
        }
        return false;
    }
    public static int Max(this int[] arr, int i)
    {
        if (i >= arr.Length)
        {
            return 0;
        }
        return Max(arr, i, 0);
    }
    private static int Max(int[] arr, int i, int mi)
    {
        if (i < 0)
        {
            return arr[mi];
        }
        if (arr[i] > arr[mi])
        {
            mi = i;
        }
        return Max(arr, --i, mi);
    }
    public static int MaxIndex(this int[] arr, int i)
    {
        if (i >= arr.Length)
        {
            return 0;
        }
        return MaxIndex(arr, i, 0);
    }
    private static int MaxIndex(int[] arr, int i, int mi)
    {
        if (i < 0)
        {
            return mi;
        }
        if (arr[i] > arr[mi])
        {
            mi = i;
        }
        return MaxIndex(arr, --i, mi);
    }
    public static bool Contains(this int[] arr, int i, int j, int value)
    {
        if (i > j)
        {
            return Contain(arr, j, i, value);
        }
        return Contain(arr, i, j, value);
    }
    private static bool Contain(int[] arr, int i, int j, int value)
    {
        if (i >= arr.Length || i > j)
        {
            return false;
        }
        if (arr[i] == value)
        {
            return true;
        }
        return Contain(arr, ++i, j, value);
    }
    public static bool ContainsAndSorted(this int[] arr, int i, int j, int value)
    {
        return arr.Contains(i, j, value) && IsSorted(arr, i, j);//haha yes logic go brrr
    }
    public static bool IsEvenSumEqualOddSum(this int[] arr)
    {
        return 2 * arr.OddSum() == arr.Sum(arr.Length - 1);
    }
    private static int OddSum(this int[] arr) => OddSum(arr, arr.Length - 1);
    private static int OddSum(this int[] arr, int i)
    {
        if (i < 0)
        {
            return 0;
        }
        if (i % 2 == 0)
        {
            return OddSum(arr, --i);
        }
        return arr[i] + OddSum(arr, --i);
    }
    public static string PrintSS(this int[] arr)
    {
        return $"[{PrintSS(arr, 0)}";
    }
    public static string PrintSS(this int[] arr, int i)
    {
        if (++i >= arr.Length)
        {
            return $"]";
        }
        if (arr[i] <= arr[++i])
        {
            return PrintSS(arr, ++i);
        }
        return $"{arr[i]},{PrintSS(arr, ++i)}";
    }

}
