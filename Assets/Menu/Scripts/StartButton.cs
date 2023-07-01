using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class StartButton : MonoBehaviour
{

    [SerializeField] int _firstLevelBuildIndex;
    public void LoadGame()
    {
        EditorSceneManager.LoadScene(_firstLevelBuildIndex);
    }
}
