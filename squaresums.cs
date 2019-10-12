public static class Kata
{
  public static int SquareSum(int[] n)
  { 
        int sum=0;
          for (int i=0;i<n.Length;i++)
       {
           n[i]=n[i]*n[i];
           sum+=n[i];
       }
       return sum;
   //lambda function
   //public static int SquareSum(int[] n) => n.Sum(i => i * i);
  }
}