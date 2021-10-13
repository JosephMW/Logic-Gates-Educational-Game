using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomGridTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int width = 8;
        int height = 6;
        float cellSize = 10f;
        CustomGrid myGrid = new CustomGrid(width, height, cellSize);

        Vector3 initialCircuitPosition = new Vector3(5f, 0.7f);
        // Circuit myCircuit = new Circuit(initialCircuitPosition);
        Circuit myCircuit = gameObject.AddComponent<Circuit>().Init(initialCircuitPosition);
        // myCircuit.instantiate();
    }
}
