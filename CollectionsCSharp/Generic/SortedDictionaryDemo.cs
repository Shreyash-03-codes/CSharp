namespace CollectionsCSharp.Generic;

using System;
using System.Collections.Generic;

public class SortedDictionaryDemo
{
    public static void Main(String[] args)
    {
        
        SortedDictionary<int,int> map=new SortedDictionary<int,int>();

        map.Add(55,1);
        map.Add(47,2);
        map.Add(46,7);
        map.Add(36,4);
        map.Add(48,5);

        Console.WriteLine(map.First());
        Console.WriteLine(map.Last());

        KeyValuePair<int,int> kv=map.Last();

        Console.WriteLine(kv.Key);
        Console.WriteLine(kv.Value);

        Console.WriteLine(map[48]);

        KeyValuePair<int,int> kvMax = map.FirstOrDefault((k) =>
        {
            return k.Key>47;
        });

        Console.WriteLine(kvMax.Key);

        KeyValuePair<int,int> kvMin = map.LastOrDefault((k) =>
        {
            return k.Key<47;
        });

        Console.WriteLine(kvMin.Key);

        
    }
}