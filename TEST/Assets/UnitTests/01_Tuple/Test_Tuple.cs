using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Tuple : MonoBehaviour
{
    private void Start()
    {
        (float, int) t1 = (3.14f, 5);
        print($"float : {t1.Item1}, int : {t1.Item2}");

        (float pi, int sum, int Test) g2 = (3.14159268f, 100, 999);
        print($"Pi = {g2.pi} , sum = {g2.sum}, Test = {g2.Test}");

        (int, float Pi) t3 = (100, 3.14f);
        print($"int : {t3.Item1}, pi : {t3.Pi}");

        print($"{t3}");

        (float Pi, int, string Name) t4 = (3.14f, 10, "Song");
        print($"pi = {t4.Pi} , int = {t4.Item2} , Name : {t4.Name}");

        t4.Name += "Jea mo";
        print(t4);

        t3.Pi += 10.0f;
        print(t3);

        var t5 = (1, 2, 3, 11, 22, 33);
        print(t5);
        print(t5.Item5);

        var t6 = (3.14f, 10, "Unity", "C", 23.5);
        print(t6);
        print(t6.Item3);

        Func<(int, int, int), (int, float, string )> them = param =>
         {
             return (param.Item1 * 2, param.Item2 * 3.5f, param.Item3.ToString() + "Values");
 
         };

        var input = (2, 3, 4);
        
    }

}
