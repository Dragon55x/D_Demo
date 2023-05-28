using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor;
using UnityEditor.UIElements;

public class TestLevel : EditorWindow
{
    [MenuItem("Window/LevelEdit")]
    public static TestLevel Open()
    {
        return GetWindow<TestLevel>("¹Ø¿¨±à¼­Æ÷");
    }

    private void OnGUI()
    {
        EditorGUILayout.BeginVertical();
        {
            EditorGUILayout.Space(10);
            EditorGUILayout.LabelField("hhhh");
            EditorGUILayout.Space(10);

            EditorGUILayout.BeginHorizontal();
            {
                if (GUILayout.Button("Click"))
                {
                    Debug.Log("Click");
                }
                EditorGUILayout.Toggle(true);
            }
            EditorGUILayout.EndHorizontal();
        }
        EditorGUILayout.EndVertical();
    }
}
