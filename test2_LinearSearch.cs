using System;

public class Program
{
    public static void Main()
    {
        int[] arr = {1, 0, -1, 0, 1, 2, 3, 4, 3, 4, 5, 6, 7, 8, 9, 10, 9, 10};
        int x = -1;
          
        int result = search(arr, x); 
        if(result == -1)
            Console.WriteLine("Element is not present in array");
        else
            Console.WriteLine(result + "(index of the first occurrence of " + x + " in the array)");
    }
    
    public static int search(int[] arr, int x) 
    { 
        int n = arr.Length; 
        for(var i = 0; i < n;){
            var tmp = x - arr[i];
            if (i > n){
                return -1;
            }
            else if (tmp == 0){
                return i;
            }
            else {
                i += Math.Abs(tmp);
            }
        }
        return -1; 
    }
}