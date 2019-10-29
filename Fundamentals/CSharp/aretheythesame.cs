using System;
using System.Collections.Generic;

class AreTheySame
{
  public static bool comp(int[] a, int[] b)
  {
    if (a == null || b == null)
    {
      return false;
    }

    if (a.Length != b.Length)
    {
      return false;
    }

    List<int> bList = new List<int>(b);
    for (int i = 0; i < a.Length; i++)
    {
      int mulVal = a[i] * a[i];
      for (int j = 0; j < bList.Count; j++)
      {
        if (bList[j] == mulVal)
        {
          bList.RemoveAt(j);
          break;
        }
      }
    }

    return bList.Count == 0;
  }
}

/*
using System;
using System.Linq;

class AreTheySame
{
  public static bool comp(int[] a, int[] b)
  {
    if ((a == null) || (b == null)){
      return false;
    }

    int[] copy = a.Select(x => x * x).ToArray();
    Array.Sort(copy);
    Array.Sort(b);

    return copy.SequenceEqual(b);
  }
} */