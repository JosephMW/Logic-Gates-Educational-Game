using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class OptionsMenu : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public void SaveGame()
    {
        string saveName = textMeshPro.text;
        Debug.Log(saveName);

        var saveController = this.gameObject.GetComponent<SaveController>();

        saveController.SaveScene(saveName);
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
