using System;
public class LongestConsecutives 
{
    
    public static String LongestConsec(string[] strarr, int k) 
    {
        if(strarr.Length == 0 || k > strarr.Length || k <= 0){
          return "";
        }
        string consec="";
        bool stop = false;
        int maxlength = 0;
        string maxConsec = "";
        for(int i=0;i<strarr.Length;i++){
          consec = "";
          for(int j = 0;j < k;j++){
            if(i+j >=strarr.Length){
              stop = true;
              break;
            }
            consec +=strarr[i+j];
          }
          if(stop){
            break;
          } else if(consec.Length > maxlength){
            maxlength = consec.Length;
            maxConsec = consec;
          }
          
        }
        return maxConsec;
    }
}