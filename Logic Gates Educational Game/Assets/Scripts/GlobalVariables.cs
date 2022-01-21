using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariables : MonoBehaviour
{
    private static int ID = 0;

    public static int getID()
    {
        GlobalVariables.ID += 1;
        return GlobalVariables.ID;
    }
}
