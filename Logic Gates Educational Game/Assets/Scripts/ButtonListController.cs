using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonListController : MonoBehaviour
{
    public GameObject buttonTemplate;
    // Start is called before the first frame update
    void Start()
    {
        // find all save files.

        // for each save file, spawn a button with text = saveName;

        for (int i = 0; i < 20; i++)
        {
            GameObject button = Instantiate(buttonTemplate) as GameObject;
            button.SetActive(true);

            button.GetComponent<LoadGameButton>().setText("testSave");

            button.transform.SetParent(buttonTemplate.transform.parent, false);
        }
    }
}
