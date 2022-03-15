using System;

class Human
{
    int id;
    string name;


    public int Id
    {
        get { return id; }
        set { id = value; }
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

}
class program
{
    static void Main()
    {
        Human obj=new Human();
        obj.Id = 1000;
        obj.Name = "Ashok";
        Console.WriteLine(obj.Id);
        Console.WriteLine(obj.Name);
        Console.ReadKey();
    }
}