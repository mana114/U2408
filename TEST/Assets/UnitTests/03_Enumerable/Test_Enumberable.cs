using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Enumerable : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        List<string> names = new List<string>() //IEnumerable
        {
            "Song" , "Jea" , "MO"
        };
        Print(names);

        int[] array = new int[]
        {
            1, 5, 3, 4, 2,
        };
        Print(array);
    }

    private void Print<T>(IEnumerable<T> items)
    {
        foreach(T item in items) //IEumerator
        {
            print(item);
        }
    }
}
