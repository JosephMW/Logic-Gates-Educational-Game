using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GlobalVariables : MonoBehaviour
{
    private static int ID = 0;
    private static string toLoad = null;
    public static IDictionary<string, CircuitParent> typeDictionary = new Dictionary<string, CircuitParent>();

    void Start()
    {
        typeDictionary = new Dictionary<string, CircuitParent>();

        Object[] circuits = Resources.LoadAll("Sprites/Circuits");

        foreach (var circ in circuits)
        {
            CircuitParent circuitParent = ((UnityEngine.GameObject)circ).GetComponent<CircuitParent>();
            typeDictionary.Add(circuitParent.GetType().ToString(), circuitParent);
        }
    }

    public static int getID()
    {
        GlobalVariables.ID += 1;
        return GlobalVariables.ID;
    }

    public static void incrementIDIfNecessary(int newlyAddedID)
    {
        // This method is used when manually setting an objects ID: THIS SHOULD ONLY BE DONE IN GAME LOADING SCENARIOS.

        if (newlyAddedID > GlobalVariables.ID)
        {
            GlobalVariables.ID = newlyAddedID;
        }
    }

    public static void setToLoad(string toLoad)
    {
        GlobalVariables.toLoad = toLoad;
    }

    public static string getToLoad()
    {
        return GlobalVariables.toLoad;
    }
}
