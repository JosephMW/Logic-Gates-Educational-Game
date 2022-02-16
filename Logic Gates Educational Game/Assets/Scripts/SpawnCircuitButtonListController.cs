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
        Object[] circuits = Resources.LoadAll("Sprites/Circuits");

        int colorCounter = 0;
        foreach (var circ in circuits)
        {
            GameObject button = Instantiate(buttonTemplate) as GameObject;
            button.SetActive(true);
            SpawnCircuitButton spawnCircuitButton = button.GetComponent<SpawnCircuitButton>();
            spawnCircuitButton.setObjectToSpawn((UnityEngine.GameObject)circ);
            spawnCircuitButton.setText(circ.name);

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
