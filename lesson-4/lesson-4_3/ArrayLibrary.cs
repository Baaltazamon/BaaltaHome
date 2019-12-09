using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ArrayLibrary
{
    public ArrayLibrary(int n, int min, int step)
    {
        int m = min;
        this.Length = n;
        this.Min = min;
        int s = 0;
        int[] c = new int[Length];
        for(int i = 0; i < Length; i++)
        {
            c[i] = m;
            s += m;
            m += step;
        }
        this.mas = c;
        this.Sum = s;
    }
    public void PrintArray(int[] arr, string definition)
    {
        Console.WriteLine(definition);
        for (int i = 0; i < Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
    public int[] Inverse(int[] arr)
    {
        int[] arrInv = new int[Length];
        for (int i = 0; i < Length; i++)
        {
            arrInv[i] = arr[i] * -1;
        }
        return arrInv;
    }
    public void Multi(ref int[] arr, int n)
    {
        for (int i = 0; i < Length; i++)
        {
            arr[i] *= n;
        }
    }
    public int Max(int[] arr)
    {
        int max = arr[0];
        int maxCount = 0;
        for (int i = 0; i < Length; i++)
        {
            if (arr[i] > max)
                max = arr[i];
        }
        for (int i = 0; i < Length; i++)
        {
            if (arr[i] == max)
                maxCount++;
        }
        return maxCount;
    }
    public int[] mas;
    public int Length;
    public int Min;
    public int Sum;
    public int MaxCount;

}

