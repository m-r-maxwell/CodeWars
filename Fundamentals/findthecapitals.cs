using System.Collections.Generic;

public static class Kata
{
  public static int[] Capitals(string word)
  {
		var caps = new List<int>();
    
    for(int i = 0; i < word.Length;i++){
      char c = word[i];
      if(c != char.ToLower(c)){
      caps.Add(i);
      }
    }
    
    return caps.ToArray();
    
  }
}