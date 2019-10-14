public class Kata
{
  public static string[] TowerBuilder(int nFloors)
  {
    string[] result = new string[nFloors];
    int len = (nFloors -1 ) * 2 + 1 ;

    for(int i = 0; i < nFloors; i++){
        int star = i * 2 + 1;
        int gap = (len - star) / 2;
        string li = "";
        for(int x = 0; x < gap; x++){li += " ";}
        for(int x = 0; x < star; x++){li += "*";}
        for(int x = 0; x < gap; x++){li += " ";}
        result[i] = li;

    }

    return result;
  }
}