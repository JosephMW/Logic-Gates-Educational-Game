using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static SaveController;

public class LoadController : MonoBehaviour
{
    public GameObject passThroughCirc; //This is temporary!
    public CustomGrid customGrid; //This is temporary!
    public void LoadScene()
    {
        string saveName = "FirstSave";

        Debug.Log("Load Scene called");

        SceneManager.LoadScene("NewGame");


        string fileContents = System.IO.File.ReadAllText(Application.dataPath + "/SaveFiles/" + saveName + ".json");
        // Debug.Log(fileContents);
        SaveFormat saveFormat = JsonUtility.FromJson<SaveFormat>(fileContents);
        // Debug.Log(saveFormat.circuitJsons.Count);
        for (int i = 0; i < saveFormat.circuitJsons.Count; i++)
        {
            string currentCircuitJson = saveFormat.circuitJsons[i];

            CircuitSaveFormat circuitSaveFormat = JsonUtility.FromJson<CircuitSaveFormat>(currentCircuitJson);

            for (int j = 0; j < circuitSaveFormat.inputPortJsons.Count; j++)
            {
                string currentInputPortJson = circuitSaveFormat.inputPortJsons[j];

                InputPortSaveFormat inputPortSaveFormat = JsonUtility.FromJson<InputPortSaveFormat>(currentInputPortJson);
            }

            for (int k = 0; k < circuitSaveFormat.wireJsons.Count; k++)
            {
                string currentWireJson = circuitSaveFormat.wireJsons[k];

                WireSaveFormat wireSaveFormat = JsonUtility.FromJson<WireSaveFormat>(currentWireJson);
            }

            // Debug.Log("circuitSaveFormat.circuitType");
            // Debug.Log(circuitSaveFormat.circuitType);
            // Debug.Log("circuitSaveFormat.circuitID");
            // Debug.Log(circuitSaveFormat.circuitID);

            GameObject newObject = Instantiate(passThroughCirc, circuitSaveFormat.location, Quaternion.identity);
            // DragAndDrop dragAndDrop = newObject.GetComponent<DragAndDrop>();
            // dragAndDrop.customGrid = this.customGrid;
            Debug.Log(newObject);
        }
    }
}