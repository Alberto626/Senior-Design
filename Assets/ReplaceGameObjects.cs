using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

    #if (UNITY_EDITOR) 
public class ReplaceGameObjects : EditorWindow
{


    [SerializeField] private GameObject prefab;

    [MenuItem("Tools/Replace With Prefab")]
    static void CreateReplaceWithPrefab() {
        EditorWindow.GetWindow<ReplaceGameObjects>();
    }

    private void OnGUI () {
        prefab = (GameObject)EditorGUILayout.ObjectField("Prefab", prefab, typeof(GameObject), false);

        if (GUILayout.Button("Replace"))
        {
            var selection = Selection.gameObjects;
            

            for (var i = selection.Length - 1; i >= 0; --i)
            {
                var selected = selection[i];
                var prefabType = PrefabUtility.GetPrefabType(prefab);
                GameObject newObject;

                if (prefabType  == PrefabType.Prefab)
                {
                    newObject = (GameObject)PrefabUtility.InstantiatePrefab(prefab);
                }
                else
                {
                    Debug.LogError("Error instantiating prefab");
                    break;
                }

                Undo.RegisterCreatedObjectUndo (newObject, "Replace With Prefabs");
                newObject.transform.parent = selected.transform.parent;
                newObject.transform.localPosition = selected.transform.localPosition;
                newObject.transform.localRotation = selected.transform.localRotation;
                newObject.transform.localScale = selected.transform.localScale;
                newObject.transform.SetSiblingIndex(selected.transform.GetSiblingIndex());
                Undo.DestroyObjectImmediate(selected);
            }
        }

        GUI.enabled = false;
        EditorGUILayout.LabelField("Selection count: " + Selection.objects.Length);
    }

}
    #endif
    // public bool copyValues = true;
    // public GameObject NewType;
    // public GameObject[] OldObjects;
 
    // [MenuItem("Custom/Replace GameObjects")]
 
 
    // static void CreateWizard()
    // {
    //     ScriptableWizard.DisplayWizard("Replace GameObjects", typeof(ReplaceGameObjects), "Replace");
    // }
 
    // void OnWizardCreate()
    // {
    //     //Transform[] Replaces;
    //     //Replaces = Replace.GetComponentsInChildren<Transform>();
 
    //     foreach (GameObject go in OldObjects)
    //     {
    //         GameObject newObject;
    //         newObject = (GameObject)EditorUtility.InstantiatePrefab(NewType);
    //         newObject.transform.position = go.transform.position;
    //         newObject.transform.rotation = go.transform.rotation;
    //         newObject.transform.parent = go.transform.parent;
 
    //         DestroyImmediate(go);
 
    //     }
 
    // }
