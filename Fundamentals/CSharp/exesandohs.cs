using System.Linq;
using System;
public static class Kata 
{
  public static bool XO (string input)
  {
    input = input.ToLower();
    var x = 0;
    var o = 0;

    for(var i = 0; i < input.Length; i++){
        if(input[i] == 'x'){
            x++;
        }
        else if(input[i] == 'o'){
            o++;
        }
    }
    if(x == o){
        return true;
    }
    else{
        return false;
    }
  }
}
// return input.ToLower().Count(i => i == 'x') == input.ToLower().Count(i => i == 'o');