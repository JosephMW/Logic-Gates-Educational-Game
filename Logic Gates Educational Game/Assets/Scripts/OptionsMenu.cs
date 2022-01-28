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
        SceneManager.LoadScene("MainMenu");
    }
}
