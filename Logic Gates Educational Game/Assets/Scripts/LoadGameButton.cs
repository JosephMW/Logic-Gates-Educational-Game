using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LoadGameButton : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public LoadController loadController;

    public void setText(string newText)
    {
        textMeshPro.text = newText;
    }

    public void onClick()
    {
        loadController.LoadScene(textMeshPro.text);
    }
}
