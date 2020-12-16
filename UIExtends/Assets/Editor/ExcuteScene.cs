using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEditor.SceneManagement;

public static class ExcuteScene
{
    [MenuItem("Scenes/CatchScene &F5")]
    public static void ShowScene()
    {
        EditorSceneManager.OpenScene("Assets/Entities/Catch/Scenes/CatchScene.unity");
        EditorApplication.ExecuteMenuItem("Edit/Play");
    }
}
