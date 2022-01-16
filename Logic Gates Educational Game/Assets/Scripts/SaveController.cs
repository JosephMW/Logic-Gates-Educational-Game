using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveController : MonoBehaviour
{
    // Start is called before the first frame update
    public void SaveScene()
    {
        Debug.Log("SaveScene Called");

        CircuitParent[] objs = GameObject.FindObjectsOfType<CircuitParent>();
        for (int i = 0; i < objs.Length; i++)
        {
            var currentObject = objs[i];
            Debug.Log(currentObject);
            string json = JsonUtility.ToJson(currentObject);
            Debug.Log("My Json:");
            Debug.Log(json);

            Wire[] currentObjectWires = currentObject.outputWires;
            for (int j = 0; j < currentObjectWires.Length; j++)
            {
                var currentObjectWire = currentObjectWires[j];
                Debug.Log(currentObjectWire);
                string wireJson = JsonUtility.ToJson(currentObjectWire);
                Debug.Log("My Wire Json:");
                Debug.Log(wireJson);
            }

            // We want to format our circuit in custom class CircuitJson:

            CircuitJson circJson = new CircuitJson();
        }
    }

    private class CircuitJson
    {
        type circuitType;
        wireJson[] wires;
        cpJson[] cps;

        private class wireJson
        {
            int WireID;
            int ConnectionPortID;
        }

        private class cpJson
        {
            int ConnectionPortID;
        }
    }
}

