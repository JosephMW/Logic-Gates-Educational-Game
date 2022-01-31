using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static SaveController;

public class LoadController : MonoBehaviour
{
    private List<(int wireID, int inputPortID)> wirePortPairings;
    public CustomGrid customGrid;
    public void LoadScene()
    {
        string saveName = "FirstSave";
        GlobalVariables.setToLoad(saveName);

        SceneManager.LoadScene("NewGame");
    }

    void Start()
    {
        string saveName = GlobalVariables.getToLoad();
        if (saveName == null)
        {
            return;
        }

        wirePortPairings = new List<(int wireID, int inputPortID)>();
        string fileContents = System.IO.File.ReadAllText(Application.dataPath + "/SaveFiles/" + saveName + ".json");

        SaveFormat saveFormat = JsonUtility.FromJson<SaveFormat>(fileContents);

        for (int i = 0; i < saveFormat.circuitJsons.Count; i++)
        {
            string currentCircuitJson = saveFormat.circuitJsons[i];

            CircuitSaveFormat circuitSaveFormat = JsonUtility.FromJson<CircuitSaveFormat>(currentCircuitJson);

            int[] inputPortIDs = new int[circuitSaveFormat.inputPortJsons.Count];
            for (int j = 0; j < circuitSaveFormat.inputPortJsons.Count; j++)
            {
                string currentInputPortJson = circuitSaveFormat.inputPortJsons[j];

                InputPortSaveFormat inputPortSaveFormat = JsonUtility.FromJson<InputPortSaveFormat>(currentInputPortJson);

                inputPortIDs[j] = inputPortSaveFormat.inputPortID;
            }

            int[] wireIDs = new int[circuitSaveFormat.wireJsons.Count];
            for (int k = 0; k < circuitSaveFormat.wireJsons.Count; k++)
            {
                string currentWireJson = circuitSaveFormat.wireJsons[k];

                WireSaveFormat wireSaveFormat = JsonUtility.FromJson<WireSaveFormat>(currentWireJson);

                wireIDs[k] = wireSaveFormat.wireID;
                wirePortPairings.Add((wireSaveFormat.wireID, wireSaveFormat.inputPortID));
            }

            // Instantiate the Circuit:
            GameObject toBeInstantiated = GlobalVariables.typeDictionary[circuitSaveFormat.circuitType].gameObject;
            GameObject newObject = Instantiate(toBeInstantiated, circuitSaveFormat.location, Quaternion.identity);

            // Get the CircuitParent component and set the IDs of it and its ports&wires:
            CircuitParent circuitParent = newObject.GetComponent<CircuitParent>();
            circuitParent.setCustomIDs(circuitSaveFormat.circuitID, inputPortIDs, wireIDs);

            // Set the dragAndDrop reference so the object sticks to the grid:
            DragAndDrop dragAndDrop = newObject.GetComponent<DragAndDrop>();
            dragAndDrop.customGrid = this.customGrid;
        }

        // Now we have loaded the circuits we reset ToLoad value.
        GlobalVariables.setToLoad(null);

        for (int i = 0; i < wirePortPairings.Count; i++)
        {
            // Debug.Log("Wire");
            // Debug.Log(wirePortPairings[i].wireID);
            // Debug.Log("Port");
            // Debug.Log(wirePortPairings[i].inputPortID);
        }
    }
}
