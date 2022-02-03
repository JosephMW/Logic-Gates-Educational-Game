using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SpawnCircuitButtonListController : MonoBehaviour
{
    public GameObject buttonTemplate;

    // Start is called before the first frame update
    void Start()
    {
        DirectoryInfo d = new DirectoryInfo(Application.dataPath + "/Resources/Sprites/Circuits/");

        foreach (var file in d.GetFiles("*.prefab"))
        {
            string circuitName = file.Name.Substring(0, file.Name.Length - 7);

            GameObject button = Instantiate(buttonTemplate) as GameObject;
            button.SetActive(true);
            SpawnCircuitButton spawnCircuitButton = button.GetComponent<SpawnCircuitButton>();
            spawnCircuitButton.setObjectToSpawn((UnityEngine.GameObject)Resources.Load("Sprites/Circuits/" + circuitName));
            spawnCircuitButton.setText(circuitName);
            button.transform.SetParent(buttonTemplate.transform.parent, false);
        }
    }
}
