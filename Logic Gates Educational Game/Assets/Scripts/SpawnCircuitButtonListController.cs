using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SpawnCircuitButtonListController : MonoBehaviour
{
    public GameObject buttonTemplate;
    public GameObject objectToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        // DirectoryInfo d = new DirectoryInfo(Application.dataPath + "/SaveFiles/");

        // foreach (var file in d.GetFiles("*.json"))
        // {
        //     string saveName = file.Name.Substring(0, file.Name.Length - 5);

        //     GameObject button = Instantiate(buttonTemplate) as GameObject;
        //     button.SetActive(true);
        //     button.GetComponent<LoadGameButton>().setText(saveName);
        //     button.transform.SetParent(buttonTemplate.transform.parent, false);
        // }

        for (int i = 0; i < 20; i++)
        {
            GameObject button = Instantiate(buttonTemplate) as GameObject;
            button.SetActive(true);
            SpawnCircuitButton spawnCircuitButton = button.GetComponent<SpawnCircuitButton>();
            spawnCircuitButton.setObjectToSpawn(objectToSpawn);
            spawnCircuitButton.setText("And2GATE for example");
            button.transform.SetParent(buttonTemplate.transform.parent, false);
        }
    }
}
