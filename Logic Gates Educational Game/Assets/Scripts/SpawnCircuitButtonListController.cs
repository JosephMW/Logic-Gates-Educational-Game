using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpawnCircuitButtonListController : MonoBehaviour
{
    public GameObject buttonTemplate;
    private bool collapsed = false;
    public TextMeshProUGUI textMeshPro;

    public Color[] colorList;

    // Start is called before the first frame update
    void Start()
    {
        DirectoryInfo d = new DirectoryInfo(Application.dataPath + "/Resources/Sprites/Circuits/");

        int colorCounter = 0;
        foreach (var file in d.GetFiles("*.prefab"))
        {
            string circuitName = file.Name.Substring(0, file.Name.Length - 7);

            GameObject button = Instantiate(buttonTemplate) as GameObject;
            button.SetActive(true);
            SpawnCircuitButton spawnCircuitButton = button.GetComponent<SpawnCircuitButton>();
            spawnCircuitButton.setObjectToSpawn((UnityEngine.GameObject)Resources.Load("Sprites/Circuits/" + circuitName));
            spawnCircuitButton.setText(circuitName);

            button.GetComponent<Image>().color = colorList[colorCounter % colorList.Length];

            button.transform.SetParent(buttonTemplate.transform.parent, false);

            colorCounter++;
        }
    }

    public void collapseList()
    {
        this.transform.localPosition = this.transform.localPosition + new Vector3(0, (collapsed ? 200 : -200), 0);
        textMeshPro.text = collapsed ? "Hide Spawner" : "Show Spawner";
        this.collapsed = !this.collapsed;
    }
}
