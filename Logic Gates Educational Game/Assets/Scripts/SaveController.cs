using System;
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

        JsonSaveFormat newSave = new JsonSaveFormat();

        CircuitParent[] circuits = GameObject.FindObjectsOfType<CircuitParent>();
        for (int i = 0; i < circuits.Length; i++)
        {
            Debug.Log(circuits[i]);
            newSave.addCircuit(circuits[i]);
        }

        Wire[] wires = GameObject.FindObjectsOfType<Wire>();
        for (int i = 0; i < wires.Length; i++)
        {
            newSave.addWire(wires[i]);
        }

        string json = JsonUtility.ToJson(newSave);
        Debug.Log(json);

        // CircuitParent[] objs = GameObject.FindObjectsOfType<CircuitParent>();
        // for (int i = 0; i < objs.Length; i++)
        // {
        //     var currentObject = objs[i];
        //     Debug.Log(currentObject);
        //     string json = JsonUtility.ToJson(currentObject);
        //     Debug.Log("My Json:");
        //     Debug.Log(json);

        //     Wire[] currentObjectWires = currentObject.outputWires;
        //     for (int j = 0; j < currentObjectWires.Length; j++)
        //     {
        //         var currentObjectWire = currentObjectWires[j];
        //         Debug.Log(currentObjectWire);
        //         string wireJson = JsonUtility.ToJson(currentObjectWire);
        //         Debug.Log("My Wire Json:");
        //         Debug.Log(wireJson);
        //     }

        //     // We want to format our circuit in custom class CircuitJson:

        //     CircuitJson circJson = new CircuitJson();
        // }
    }

    [Serializable]
    public class JsonSaveFormat
    {
        public List<CircuitParent> circuits;
        public List<Wire> wires;

        public JsonSaveFormat()
        {
            this.circuits = new List<CircuitParent>();
            this.wires = new List<Wire>();
        }

        public void addCircuit(CircuitParent newCircuit)
        {
            circuits.Add(newCircuit);
        }

        public void addWire(Wire newWire)
        {
            wires.Add(newWire);
        }
    }

    private void getCircuitsJson()
    {
        CircuitParent[] circuits = GameObject.FindObjectsOfType<CircuitParent>();
        for (int i = 0; i < circuits.Length; i++)
        {
            var currentCircuit = circuits[i];
            Debug.Log(currentCircuit);
            string json = JsonUtility.ToJson(currentCircuit);
            Debug.Log("My Json:");
            Debug.Log(json);

        }
    }

    private void getWiresJson()
    {

    }
}

