using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif


// Sets the script to be executed later than all default scripts
// This is helpful for UI, since other things may need to be initialized before setting the UI
[DefaultExecutionOrder(1000)]
public class MenuUI : MonoBehaviour
{

    public Text playerInput;

    private void Start()
    {
    }

    public void StartNew()
    {
        // load scene with index 1 (main)
        SceneManager.LoadScene(1);
    }


    public void SetPlayerName() 
    { 
   
        Debug.Log(playerInput.text);
        MainManager.Instance.playerName = playerInput.text;
        //Debug.Log(MainManager.Instance.playerName);
    }



    public void SaveColorClicked()
    {
        //MainManager.Instance.SaveColor();
    }

    public void LoadColorClicked()
    {
        //MainManager.Instance.LoadColor();
    }


    public void Exit()
    {
        //quit application
        //# is a compiler instruction 
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }


}
