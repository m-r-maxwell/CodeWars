using System;

public static class Kata
{
  public static int Factorial(int n)
  {
    int result = 1;
    if(n < 0 || n > 12){
    throw new ArgumentOutOfRangeException("Out of range");
    }
    for(int i = 1; i <= n; i++){
    result *= i;
    }
    return result;
  }
}//return n > 0 ? n * Factorial(n - 1) : 1;