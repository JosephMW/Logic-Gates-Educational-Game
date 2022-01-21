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

            CircuitSaveFormat circuitSave = new CircuitSaveFormat(currentCircuit.circuitID, currentCircuit.GetType().ToString());

            InputPort[] currentCircuitInputPorts = currentCircuit.inputPorts;
            for (int j = 0; j < currentCircuitInputPorts.Length; j++)
            {
                var currentCircuitInputPort = currentCircuitInputPorts[j];

                InputPortSaveFormat inputPortSave = new InputPortSaveFormat(currentCircuitInputPort.inputPortID);

                string inputPortJson = JsonUtility.ToJson(inputPortSave);
                circuitSave.addInputPortJson(inputPortJson);
            }

            Wire[] currentCircuitWires = currentCircuit.outputWires;
            for (int j = 0; j < currentCircuitWires.Length; j++)
            {
                var currentCircuitWire = currentCircuitWires[j];

                WireSaveFormat wireSave = new WireSaveFormat(currentCircuitWire.wireID, currentCircuitWire.connectionPoint ? currentCircuitWire.connectionPoint.inputPortID : 9999);

                string wireJson = JsonUtility.ToJson(wireSave);
                circuitSave.addWireJson(wireJson);
            }

            string circuitJson = JsonUtility.ToJson(circuitSave);
            Debug.Log("circuitJson");
            Debug.Log(circuitJson);
        }
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
        public string circuitType;
        public List<string> wireJsons;
        public List<string> inputPortJsons;

        public CircuitSaveFormat(int circuitID, string circuitType)
        {
            this.circuitType = circuitType;
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

