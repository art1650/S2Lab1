using System.Collections.Generic;
using System.Text.Json;

try
{
    int n;
    List<int> list = new List<int>();
    list.Add(0);
    list.Add(1);
    list.Add(2);
    list.Add(3);
    list.Add(4);
    list.Add(5);
    list.Add(6);
    list.Add(7);
    Console.WriteLine(list.Count);

    for (int i = 0; i < list.Count; i++)
    {
        Console.Write(list[i] + " ");
    }

    Console.WriteLine();

    if (list.Count % 2 == 0)
    {
        for (int i = 0; i < list.Count - 1; i += 2)
        {
            n = list[i];
            list[i] = list[i + 1];
            list[i + 1] = n;
        }
    }
    else
    {
        for (int i = 0; i < list.Count - 2; i += 2)
        {
            n = list[i];
            list[i] = list[i + 1];
            list[i + 1] = n;
        }
    }

    for (int i = 0; i < list.Count; i++)
    {
        Console.Write(list[i] + " ");
    }
    
}
catch
{
    Console.WriteLine("error");
}

try
{
    Console.WriteLine();
    Console.WriteLine("----------------");
    Console.WriteLine("старий словник");

    Dictionary<int, int> dict = new Dictionary<int, int>();
    dict.Add(0, 0);
    dict.Add(2, 1);
    dict.Add(1, 2);
    foreach (KeyValuePair<int, int> kvp in dict)
    {
        Console.WriteLine(kvp.Key + " " + kvp.Value);
    }

    KeyValuePair<int, int> max = dict.Aggregate((x, y) => x.Value > y.Value ? x : y);
    KeyValuePair<int, int> min = dict.Aggregate((x, y) => x.Value < y.Value ? x : y);

    dict.Remove(max.Key);
    dict.Remove(min.Key);

    Console.WriteLine("новий слокник");

    //foreach (KeyValuePair<int, int> kvp in dict)
    //{
    //    Console.WriteLine(kvp.Key + " " + kvp.Value);
    //}

    string s = JsonSerializer.Serialize(dict);
    Console.WriteLine(s);
}
catch
{
    Console.WriteLine("error");
}
Console.WriteLine("----------------");

Console.WriteLine("кількість додатніх елементів");
List<int> listnew = new List<int>() {5, -6, 2, 6, -7 };
var sel = (from i in listnew
          where i > 0
          orderby i 
          select i).Count();
Console.WriteLine(sel);
Console.WriteLine("сума непарних елементів");

var dva = (from i in listnew
          where i % 2 != 0
          select i).Sum();
Console.WriteLine(dva);
