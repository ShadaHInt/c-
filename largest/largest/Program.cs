namespace exm;
class pgm
{
    static void Main(string[] args)
    {
        int[] a = new int[4];
        int n;
        Console.Write("enter array elements");
        for (int i = 0; i < 4; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        Array.Sort(a);
        
        Console.Write(a[2]);
        
    }
}