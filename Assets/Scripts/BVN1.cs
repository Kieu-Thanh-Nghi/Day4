using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class BVN1 : MonoBehaviour
{
    [Header("Ngay trong tuan (1 -> 7)")]
    [SerializeField] int day_of_week = 1;
    
    [ContextMenu("even_odd")]
    public void even_odd()
    {
        if(day_of_week < 1 || day_of_week > 7)
        {
            Debug.Log("Khong co ngay thu " + day_of_week + " trong tuan");
        }
        else if(day_of_week % 2 == 0)
        {
            Debug.Log("Ngay chan");
        }
        else
        {
            Debug.Log("Ngay le");
        }
        print("\n");
    }

    [ContextMenu("Thu")]
    public void thu()
    {
        switch (day_of_week)
        {
            case 1:
                Debug.Log("Chu Nhat");
                break;
            case 2:
                Debug.Log("Thu Hai");
                break;
            case 3:
                Debug.Log("Thu ba");
                break;
            case 4:
                Debug.Log("Thu tu");
                break;
            case 5:
                Debug.Log("Thu nam");
                break;
            case 6:
                Debug.Log("Thu sau");
                break;
            case 7:
                Debug.Log("Thu bay");
                break;
        }
        print("\n");
    }
}

[CustomEditor(typeof(BVN1))]
public class BVN1_editor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        BVN1 edi = (BVN1)target;
        if(GUILayout.Button("Ngay chan hay le?"))
        {
            edi.even_odd();
        }
        if(GUILayout.Button("Ten thu trong tuan la?"))
        {
            edi.thu();
        }
    }
}
