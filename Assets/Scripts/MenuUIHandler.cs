using System;
using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
 using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField usernameInput;
    public void StartNew()
    {
        SaveName();
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {   
        GameManager.Instance.SavePlayer(); 
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit(); // original code to quit Unity player
        #endif
    }

    public void SaveName(){
        GameManager.Instance.playerName = usernameInput.text;
    }

    public void SavePlayerClicked()
    {
        GameManager.Instance.SavePlayer();
    }

    public void LoadPlayerClicked()
    {
        GameManager.Instance.LoadPlayer();
        usernameInput.text = GameManager.Instance.playerName;
    }
}
