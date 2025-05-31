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
    }

    void test1()
    {
        andResult = (true && false);
        orResult = (true || false);
        notResult = !true;

        Debug.Log("and: " + andResult);
        Debug.Log("or: " + orResult);
        Debug.Log("not: " + notResult);
    }

    [SerializeField] private int score = 85;
    void test2()
    {
        if(score >= 90)
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
    }

    [SerializeField] private int day = 3;
    void test3()
    {
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
    }

    void test4()
    {
        for(int i = 0; i < 5; i++)
        {
            Debug.Log("i: " + i);
        }
    }

    void test5()
    {
        int i = 0;
        while(i < 5)
        {
            Debug.Log("i: " + i);
            i++;
        }
    }

    [SerializeField] private int i = 0;
    void test6()
    {
        do
        {
            Debug.Log("i: " + i);
            i++;
        } while (i < 5);
    }
}

