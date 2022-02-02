using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class OptionsMenu : MonoBehaviour
{
    public TextMeshProUGUI inputText;
    public TextMeshProUGUI placeholderText;

    public void SaveGame()
    {
        string saveName = inputText.text;

        if (saveName.Length == 1)
        {
            placeholderText.text = "ENTER A SAVE NAME";
            return;
        }

        var saveController = this.gameObject.GetComponent<SaveController>();
        saveController.SaveScene(saveName);
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
