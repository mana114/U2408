using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_AnonymousType : MonoBehaviour
{
    private void Start()
    {
        var t1 = new { Name = "¼¼Á¾´ë¿Õ", Year = 1700, Age = 50 };

        print(t1);
        print($"{t1.Name}, {t1.Year}, {t1.Age}");

        //t1.Name = "nono"; only read

        var t2 = new { Name = "Song", Year = 1999, Age = 26 };
        print(t1);
        print($"{t1.Name}, {t1.Year}, {t1.Age}");

        var t3 = new { t1.Name, t2.Year, Age = 30 };
        print(t3);

        t1 = t3;
        print(t1);
    }
}
