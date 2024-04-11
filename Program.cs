using System.Numerics;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] myArray = { 1, 2,3,4,5,6,7,8,};
        int[] myArrayTwo = {10,11,12,13,14,15,16,17,18,19};
        Console.WriteLine("Gia tri lon nhat cua mang la " + MaxValue(myArray));
        Console.WriteLine("Gia tri lon nhat cua mang hai la " + MaxValue(myArrayTwo));
    }
    private static int MaxValue(int[] arrayValue)
    {
        int maxValue=0;
        for (int i = 0; i < arrayValue.Length; i++)
        {
            if(maxValue<arrayValue[i])
            {
                maxValue=arrayValue[i];
            }
        }
        return maxValue;
    }
    
}