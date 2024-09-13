using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Enumberable : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        List<string> names = new List<string>() //IEnumerable
        {
            "Song" , "Jea" , "MO"
        };
        Print(names);

        Dictionary<string, Color> colorMap = new Dictionary<string, Color>()
        {
            ["Error"] = Color.red,
            ["Waring"] = Color.yellow,
            ["Information"] = Color.blue
        };

        Print(colorMap);
        Print(colorMap.Keys);
        Print(colorMap.Values);

        IEnumerable<KeyValuePair<string, Color>> colorMap2 = colorMap;
        Print(colorMap2);
    }

    private void Print<T>(IEnumerable<T> items)
    {
        foreach(T item in items) //IEumerator
        {
            print(item);
        }
    }
}
