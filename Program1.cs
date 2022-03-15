using System;

class My
{
    public int[] ar2 = new int[5];
 

    public void setvalues()
    {
        ar2[0] =3;
        ar2[1] = 7;
        ar2[2] = 8;
        ar2[3] = 9;
        ar2[4] = 10;

    }

    public int sum(int[] sm)
    {
        int ad = 0;
        for (int i = 0; i < sm.Length; i++)
        {
            ad=ad+sm[i];


        }
        return (ad);

    }
}
class My2
{
    public static void Main()
    {

        My obj = new My();
         int[] ar = { 4, 5, 6, 7, 2 };
        obj.setvalues();
    int x=  obj.sum(obj.ar2);
        Console.WriteLine("Sum of array {0} ", x);
        int y = obj.sum(ar);
        Console.WriteLine("Sum of array2  {0}", y);
        Console.ReadKey();
    }
}
