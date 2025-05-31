using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicDataPypes : MonoBehaviour
{
    [SerializeField] private bool andResult;
    [SerializeField] private bool orResult;
    [SerializeField] private bool notResult;

    private void Start()
    {
        test1();
        test2();
        test3();
        test4();
        test5();
        test6();
    }

    void test1()
    {
        Debug.Log("Test1");
        andResult = (true && false);
        orResult = (true || false);
        notResult = !true;

        Debug.Log("and: " + andResult);
        Debug.Log("or: " + orResult);
        Debug.Log("not: " + notResult);
        print("\n");
    }

    [SerializeField] private int score = 85;
    void test2()
    {
        Debug.Log("Test2");
        if (score >= 90)
        {
            Debug.Log("Grade: A");
        }else if(score >= 80)
        {
            Debug.Log("Grade: B");
        }
        else
        {
            Debug.Log("Grade: C");
        }
        print("\n");
    }

    [SerializeField] private int day = 3;
    void test3()
    {
        Debug.Log("Test3");
        switch (day)
        {
            case 1:
                Debug.Log("Monday");
                break;
            case 2:
                Debug.Log("Tuesday");
                break;
            case 3:
                Debug.Log("Wednesday");
                break;
            default:
                Debug.Log("Other day");
                break;
        }
        print("\n");
    }

    void test4()
    {
        Debug.Log("Test4");
        for (int i = 0; i < 5; i++)
        {
            Debug.Log("i: " + i);
        }
        print("\n");
    }

    void test5()
    {
        Debug.Log("Test5");
        int i = 0;
        while(i < 5)
        {
            Debug.Log("i: " + i);
            i++;
        }
        print("\n");
    }

    [SerializeField] private int i = 0;
    void test6()
    {
        Debug.Log("Test6");
        do
        {
            Debug.Log("i: " + i);
            i++;
        } while (i < 5);
        print("\n");
    }
}

