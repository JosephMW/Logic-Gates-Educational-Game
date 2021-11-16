using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCircuit : MonoBehaviour
{
    public GameObject objectToSpawn;
    private void OnMouseDown()
    {
        Debug.Log("You clicked the big red button");

        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Instantiate(objectToSpawn, mousePosition + new Vector3(0, 1, 0), Quaternion.identity);
    }
}
