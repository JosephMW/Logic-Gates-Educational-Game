using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnCircuit : MonoBehaviour
{
    public GameObject objectToSpawn;
    public CustomGrid customGrid;

    void Start()
    {
        this.gameObject.GetComponent<Button>().onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        GameObject newObject = Instantiate(objectToSpawn, mousePosition, Quaternion.identity);

        DragAndDrop dragAndDrop = newObject.GetComponent<DragAndDrop>();
        dragAndDrop.customGrid = this.customGrid;
        dragAndDrop.dragging = true;

        // Set default IDs on the circuit and its inputPorts & Wires since it has not been loaded into the scene.
        CircuitParent circuitParent = newObject.GetComponent<CircuitParent>();
        circuitParent.setDefaultIDs();
    }
}