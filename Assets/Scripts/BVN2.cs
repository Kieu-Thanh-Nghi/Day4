using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class BVN2 : MonoBehaviour
{
    [SerializeField] private string[] names;

    [ContextMenu("In ten Players")]
    public void print_ten()
    {
        Debug.Log("Bai 2");
        int n = names.Length;
        if(n < 1)
        {
            Debug.Log("Khong co ai");
        }
        else
        {
            Debug.Log("Danh sach cac nguoi choi la:");
            for(int i = 0; i < n; i++)
            {
                if (names[i] == "") continue;
                Debug.Log("Player1: " + names[i]);
            }
        }
        print("\n");
    }
}

[CustomEditor(typeof(BVN2))]
public class BVN2_editor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        BVN2 giaibai = (BVN2)target;

        if (GUILayout.Button("In ten Players"))
        {
            giaibai.print_ten();
        }
    }
}
