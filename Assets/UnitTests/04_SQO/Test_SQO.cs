using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Test_SQO : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Patent[] patents = TestDatas.Patents;
        //IEnumerable<Patent> patents2 = patents;

        Func<Patent, bool> func = (patent) => patent.YearOfPublication.StartsWith("18");
        bool bResult = func(patents[0]);
        bool bResult2 = func(patents[1]);
        //Print($"{bResult}, {bResult2}");

        Predicate<Patent> predicate = (patent) => patent.Title.StartsWith("Bi");
        bool bResult3 = predicate(patents[0]);
        bool bResult4 = predicate(patents[1]);
        //print($"{bResult3}, {bResult4}");

        List<Patent> patentList = new List<Patent>();
        foreach(Patent p in patents)
        {
            if (func(p))
                patentList.Add(p);
        }
        //Print(patentList);

        IEnumerable<Patent> patents3 = patents.Where(func);
        //Print(patents3);

        IEnumerable<Patent> patents4 = patents.Where(patent => patent.YearOfPublication.StartsWith("18"));
        //Print(patents4);

        IEnumerable<string> titles = patents.Select(patent => patent.Title);
        //Print(titles);

        IEnumerable<string> titles2 = patents
            .Select(patent => patent.Title)
            .Where(titles => titles.StartsWith("B"));
        //Print(titles2);

        IEnumerable<Patent> patents5 =
            patents.Where(patent => patent.Title.StartsWith("B"));
        //Print(patents5);
        //print(patents5.Count());

        int count = patents.Count(patent => patent.Title.StartsWith("B"));
        //print(count);

        bool bExist = patents.Any(patent => patent.Title.StartsWith("B"));
        print(bExist);

        IEnumerable<Patent> patents6 = patents.Where(patent =>
        {
            if (patent.YearOfPublication.StartsWith("18"))
            {
                print("Lambda_" + patent.Title);
                return true;
            }
            return false;
        });
        //print(" -- patent6");
        //Print(patents6); //지연된 실행 - Deffered Excuting

    }

    private void Print<T>(IEnumerable<T> items)
    {
        foreach (T item in items) //IEumerator
        {
            print(item);
        }
    }
}
