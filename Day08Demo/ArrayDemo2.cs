namespace Day08Demo;

internal class ArrayDemo2
{
    public static void Test()
    {
        int[] nums = { 55, 33, 55, 66 };

        int maxNum = nums.Max();
        int minNum = nums.Min();
        int sumNum = nums.Sum();

        Console.Write($"min={minNum}, max={maxNum},sum={sumNum}");
    }
}
