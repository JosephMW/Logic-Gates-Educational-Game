using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomGridTest : MonoBehaviour
{
    //public GameObject circuitObject;

    // public GameObject customGridObject;
    //private Circuit circuitScript;
    // private CustomGrid customGridScript;

    void Awake()
    {
        //circuitScript = circuitObject.GetComponent<Circuit>();
        Debug.Log("AWAKE");
        // customGridScript = customGridObject.GetComponent<CustomGrid>();
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("START");
        int width = 8;
        int height = 6;
        float cellSize = 10f;
        CustomGrid myGrid = new CustomGrid(width, height, cellSize);

        //circuitScript.renderCircuit(null, new Vector3(0, 0));

        // Vector3 initialCircuitPosition = new Vector3(5f, 0.7f);
        // Circuit myCircuit = new Circuit(initialCircuitPosition);
        // Circuit myCircuit = gameObject.AddComponent<Circuit>().Init(initialCircuitPosition);
        // myCircuit.instantiate();
    }
}
