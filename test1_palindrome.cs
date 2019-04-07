using System;

public class Program
{
    public static void Main()
    {
        var str = "1-2-3-4-5-4-3-2-1";
        var str_lth = str.Length;
        var s = 0;
        
        for(var i = 0; i < str_lth/2; i++){
            if (str[i] != str[str_lth - 1 - i]){
                s+=1;
            }
        }
        
        if (s != 0){
            Console.WriteLine(str + " is not palindrome");
        }
        else {
            Console.WriteLine(str + " is palindrome");
        }
    }
}