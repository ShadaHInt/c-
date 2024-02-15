namespace new1;
class pgm
{
    static void Main(string[] args)
    {
        int someInt;
        SomeMethod2(out someInt);
        Console.WriteLine(someInt);
        SomeMethod1(ref someInt);
        Console.WriteLine(someInt);
        SomeMethod(someInt);
        Console.WriteLine(someInt);
        Console.ReadLine();
    }

    static void SomeMethod(int value)
    {
        value = 0;
    }

    static void SomeMethod1(ref int value)
    {
        value = 1;
    }

    static void SomeMethod2(out int value)
    {
        value = 2;
    }
}