using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor;

[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public Text inputText;

    public void StartNew()
    {
        PassNameToManager();
        // load scene with index 1 (main)
        SceneManager.LoadScene(1);
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0);
    }


    public void ExitEditor()
    {
        EditorApplication.ExitPlaymode();
    }


    public void PassNameToManager()
    {
        DataManager.Instance.playerName = inputText.text;
    }
}
