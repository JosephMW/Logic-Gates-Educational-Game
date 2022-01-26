using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void NewGame()
    {
        GlobalVariables.setToLoad(null);
        SceneManager.LoadScene("NewGame");
    }

    public void QuitGame()
    {
        // Debug is left since Application.Quit() does not work in editor - only when built.
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
