using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveController : MonoBehaviour
{
    public void SaveScene(string saveName)
    {
        CircuitParent[] circuits = GameObject.FindObjectsOfType<CircuitParent>();

        SaveFormat gameSave = new SaveFormat();

        for (int i = 0; i < circuits.Length; i++)
        {
            CircuitParent currentCircuit = circuits[i];

            CircuitSaveFormat circuitSave = new CircuitSaveFormat(currentCircuit.circuitID, currentCircuit.GetType().ToString(), currentCircuit.transform.position);

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
            gameSave.addCircuitJson(circuitJson);
        }

        string gameSaveJson = JsonUtility.ToJson(gameSave);

        // Write to File:
        System.IO.File.WriteAllText(Application.dataPath + "/SaveFiles/" + saveName + ".json", gameSaveJson);
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
        public Vector3 location;
        public List<string> wireJsons;
        public List<string> inputPortJsons;

        public CircuitSaveFormat(int circuitID, string circuitType, Vector3 location)
        {
            this.circuitID = circuitID;
            this.circuitType = circuitType;
            this.location = location;
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

    [Serializable]
    public class SaveFormat
    {
        public List<string> circuitJsons;

        public SaveFormat()
        {
            this.circuitJsons = new List<string>();
        }

        public void addCircuitJson(string circuitJson)
        {
            this.circuitJsons.Add(circuitJson);
        }
    }
}

