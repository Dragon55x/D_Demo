using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Test_Window : EditorWindow
{
    string str = "";
    bool isChoose = false;

    [MenuItem("Test/EditorTest/Test_Window")]
    public static void ShowWindow()
    {
        GetWindow(typeof(Test_Window));
    }

    private void OnGUI()
    {
        GUILayout.Label("Setting: ");
        str = EditorGUILayout.TextField("Text Field: ", str);
        isChoose = EditorGUILayout.Toggle("Is Choose: ", isChoose);
    }
}
