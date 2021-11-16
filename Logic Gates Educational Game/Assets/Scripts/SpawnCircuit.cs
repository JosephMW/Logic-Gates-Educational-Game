using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCircuit : MonoBehaviour
{
    public GameObject objectToSpawn;
    public CustomGrid customGrid;

    private void OnMouseDown()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        GameObject newObject = Instantiate(objectToSpawn, mousePosition, Quaternion.identity);
        DragAndDrop dragAndDrop = newObject.GetComponent<DragAndDrop>();
        dragAndDrop.customGrid = this.customGrid;
        dragAndDrop.dragging = true;
    }
}
