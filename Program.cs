using System;

class My
{
    int[] arr = new int[3];
    public void Setvalue()
    { arr[0] = 1; arr[1] = 2; arr[2] = 3; }
    public void Getvalue()
    {
        foreach(int a in arr)
        {
            Console.WriteLine(a);

        }

    }
    class program
    {
        static void Main()
        {
            My ob =new My();
            ob.Setvalue();
            ob.Getvalue();
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}