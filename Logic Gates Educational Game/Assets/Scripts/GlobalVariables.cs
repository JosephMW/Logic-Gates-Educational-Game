using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariables : MonoBehaviour
{
    private static int ID = 0;
    private static string toLoad = null;

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
