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

        CircuitParent[] circuits = GameObject.FindObjectsOfType<CircuitParent>();
        for (int i = 0; i < circuits.Length; i++)
        {
            CircuitParent currentCircuit = circuits[i];

            CircuitSaveFormat circuitSave = new CircuitSaveFormat(currentCircuit.circuitID, null);

            InputPort[] currentCircuitInputPorts = currentCircuit.inputPorts;
            for (int j = 0; j < currentCircuitInputPorts.Length; j++)
            {
                var currentCircuitInputPort = currentCircuitInputPorts[j];

                InputPortSaveFormat inputPortSave = new InputPortSaveFormat(currentCircuitInputPort.inputPortID);

                string inputPortJson = JsonUtility.ToJson(inputPortSave);
                Debug.Log("inputPortJson");
                Debug.Log(inputPortJson);

                circuitSave.addInputPortJson(inputPortJson);
            }

            Wire[] currentCircuitWires = currentCircuit.outputWires;
            for (int j = 0; j < currentCircuitWires.Length; j++)
            {
                var currentCircuitWire = currentCircuitWires[j];

                WireSaveFormat wireSave = new WireSaveFormat(currentCircuitWire.wireID, currentCircuitWire.connectionPoint ? currentCircuitWire.connectionPoint.inputPortID : 9999);

                string wireJson = JsonUtility.ToJson(wireSave);
                // Debug.Log("wireJson");
                // Debug.Log(wireJson);

                circuitSave.addWireJson(wireJson);
            }

            string circuitJson = JsonUtility.ToJson(circuitSave);
            Debug.Log("circuitJson");
            Debug.Log(circuitJson);
        }

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
    public class WireSaveFormat
    {
        public int wireID;
        public int inputPortID;

        public WireSaveFormat(int wireID, int inputPortID)
        {
            this.wireID = wireID;
            this.inputPortID = inputPortID;
        }
    }

    [Serializable]
    public class InputPortSaveFormat
    {
        public int inputPortID;

        public InputPortSaveFormat(int inputPortID)
        {
            this.inputPortID = inputPortID;
        }
    }

    [Serializable]
    public class CircuitSaveFormat
    {
        public int circuitID;
        public Type circuitType;
        public List<string> wireJsons;
        public List<string> inputPortJsons;

        public CircuitSaveFormat(int circuitID, Type circuitType)
        {
            this.circuitID = circuitID;
            this.circuitType = circuitType;
            this.wireJsons = new List<string>();
            this.inputPortJsons = new List<string>();
        }

        public void addWireJson(string wireJson)
        {
            this.wireJsons.Add(wireJson);
        }

        public void addInputPortJson(string inputPortJson)
        {
            this.inputPortJsons.Add(inputPortJson);
        }
    }
}

