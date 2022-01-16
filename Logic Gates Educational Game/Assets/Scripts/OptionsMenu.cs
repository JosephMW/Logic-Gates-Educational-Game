using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{
    public void SaveGame()
    {
        var saveController = this.gameObject.GetComponent<SaveController>();
        saveController.SaveScene();
    }

    public void QuitGame()
    {
        // Debug is left since Application.Quit() does not work in editor - only when built.
        Debug.Log("Go to main menu");
        SceneManager.LoadScene("MainMenu");
    }
}
