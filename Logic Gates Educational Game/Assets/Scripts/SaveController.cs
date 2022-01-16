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

            Wire[] currentObjectWires = currentObject.outputWires;
            for (int j = 0; j < currentObjectWires.Length; j++)
            {
                var currentObjectWire = currentObjectWires[j];
                Debug.Log(currentObjectWire);
            }
        }
    }
}

