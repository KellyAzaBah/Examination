  public static class Program  
  { 
    public static void print(int [] Arr, int n) 
    { 
      if (n > 0) 
      { 
      	Console.Write(Arr[n] + " "); 
      	print(Arr, n - 1); 
      } 
      else Console.WriteLine(Arr[0]); 
    } 
    public static void Main()   
    { 
      int [] num = {1, 2, 5, 0, 10, 34}; 
      print(num, num.Length - 1); 
    }  
  }   
