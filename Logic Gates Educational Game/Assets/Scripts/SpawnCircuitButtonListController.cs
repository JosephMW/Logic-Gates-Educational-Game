using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpawnCircuitButtonListController : MonoBehaviour
{
    public GameObject buttonTemplate;
    private bool collapsed = false;
    public TextMeshProUGUI textMeshPro;

    public Color[] colorList;
    public Color switchAndLightColor;

    // Start is called before the first frame update
    void Start()
    {
        Object[] circuits = Resources.LoadAll("Sprites/Circuits");

        Object[] switches = circuits.Where(c => c.name == "Switch").ToArray();
        Object[] lights = circuits.Where(c => c.name == "Light").ToArray();
        Object[] logicGates = circuits.Where(c => (c.name != "Switch" && c.name != "Light")).ToArray();

        instantiateButtons(switches, true);
        instantiateButtons(lights, true);
        instantiateButtons(logicGates, false);
    }

    private void instantiateButtons(Object[] toSpawn, bool switchOrLight)
    {
        int colorCounter = 0;
        foreach (var circ in toSpawn)
        {
            GameObject button = Instantiate(buttonTemplate) as GameObject;
            button.SetActive(true);
            SpawnCircuitButton spawnCircuitButton = button.GetComponent<SpawnCircuitButton>();
            spawnCircuitButton.setObjectToSpawn((UnityEngine.GameObject)circ);
            spawnCircuitButton.setText(circ.name);

            button.GetComponent<Image>().color = switchOrLight ? switchAndLightColor : colorList[colorCounter % colorList.Length];

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
