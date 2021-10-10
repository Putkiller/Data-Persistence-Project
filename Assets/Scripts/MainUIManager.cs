using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class MainUIManager : MonoBehaviour
{

    
    //load
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    //high score list scene
    public void StartHighScoreScene()
    {
        SceneManager.LoadScene(2);
    }

    //go back to main menu
    public void StartMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();

#else
        Application.Quit();
#endif

    }

    public void ReadInputString(string s)
    {
        HighScore.playerName = s;
        Debug.Log("the name is " + HighScore.playerName);
    }
}
