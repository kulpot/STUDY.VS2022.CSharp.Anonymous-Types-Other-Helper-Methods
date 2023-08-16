using System;

//ref link:https://www.youtube.com/watch?v=ozzx01HbJCI&list=PL259BC2977085CF37&index=3
//Anonymous Types -- usefull, very convenient

static class MainClass
{
    static void Main()
    {
        var instance = new { FirstName = "Kulpot", LastName = "King" };
        var instance2 = new { FirstName = "Kulpot", LastName = "King" };
        var instance3 = new { FirstName = "Billy", LastName = "King" };
        Console.WriteLine(instance);
        Console.WriteLine(instance.GetType());
        Console.WriteLine(instance.GetHashCode());
        Console.WriteLine(instance2.GetHashCode());
        Console.WriteLine(instance3.GetHashCode());
        Console.WriteLine(instance.Equals(instance2));
        Console.WriteLine(instance.Equals(instance3));


    }
}