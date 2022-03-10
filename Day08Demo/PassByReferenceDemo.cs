namespace Day08Demo;

internal class PassByReferenceDemo
{
    public static void TestPassByReference()
    {
        int[] arr = new int[] { 10, 20 };
        Console.WriteLine($"Before Swap: arr[0],arr[1]={arr[0]},{arr[1]}"); // 10, 20
        Swap(arr);
        Console.WriteLine($"After Swap: arr[0],arr[1]={arr[0]},{arr[1]}");  // 20, 10
    }

    public static void Swap(int[] arrSwap)
    {
        var temp = arrSwap[0];
        arrSwap[0] = arrSwap[1];
        arrSwap[1] = temp;
        Console.WriteLine($"Inside Swap: arr[0],arr[1]={arrSwap[0]},{arrSwap[1]}");  //20, 10
    }

    public static void TestPassByValue()
    {
        int a = 10;
        int b = 20;
        
        Console.WriteLine($"Before Swap: a,b={a},{b}");     // 10,20
        Swap(a, b);
        Console.WriteLine($"After Swap: a,b={a},{b}");      // 10,20
    }

    public static void Swap(int a, int b)
    {
        int temp = a;
        a = b;
        b = temp;

        Console.WriteLine($"Inside Swap: x,y={a},{b}");     // 20,10
    }
}
