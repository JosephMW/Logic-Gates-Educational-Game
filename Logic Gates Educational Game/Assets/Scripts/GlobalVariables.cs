using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariables : MonoBehaviour
{
    private static int ID = 0;
    private static string toLoad = null;
    public CircuitParent[] circuitTypes;
    public static IDictionary<string, CircuitParent> typeDictionary = new Dictionary<string, CircuitParent>();

    void Start()
    {
        // Instantiate and fill the typeDictionary.
        typeDictionary = new Dictionary<string, CircuitParent>();
        for (int i = 0; i < circuitTypes.Length; i++)
        {
            typeDictionary.Add(circuitTypes[i].GetType().ToString(), circuitTypes[i]);
        }
    }
    public static int getID()
    {
        GlobalVariables.ID += 1;
        return GlobalVariables.ID;
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
