using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomGridTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int width = 3;
        int height = 7;
        CustomGrid myGrid = new CustomGrid(width, height);
    }
}
