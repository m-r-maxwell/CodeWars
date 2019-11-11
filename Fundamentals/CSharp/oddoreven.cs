public class Kata
{
  public static string OddOrEven(int[] array)
  {
    var sum = 0;
    
    foreach(int num in array){
      sum += num;
    }
    
    if(sum % 2 == 0){
    return "even";
    } else {return "odd";}
  }
}//one liner
// return array.Sum() % 2 == 0 ? "even" : "odd";