using System;

public class Kata
{
  public static int CalculateYears(double principal, double interest,  double tax, double desiredPrincipal)
        {
        double money = principal;
        int count = 0;
        while(desiredPrincipal > money){
            count++;
            money = money + (money * interest - (money * interest * tax));
        }
        return count;
        }
}