public static class Kata
{
  public static int SequenceSum(int start, int end, int step)
  {
      int result = 0;

      for(int i = start; i <= end; i+=step){
          result += i;
      }
  
    return result;
  }
}//return start == end ? end : start > end ? 0 : SequenceSum(start + step, end, step) + start;
//short solution