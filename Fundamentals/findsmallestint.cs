public class Kata 
{
    public static int FindSmallestInt(int[] args) 
    {
        int zero = 100;
        for(int i = 0; i < args.Length; i++){
            if(args[i] < zero){
                zero = args[i];
            }
        }

        return zero;
        //  return args.Min();
    }
    //or
    //public static int FindSmallestInt(int[] args) => args.Min();
}