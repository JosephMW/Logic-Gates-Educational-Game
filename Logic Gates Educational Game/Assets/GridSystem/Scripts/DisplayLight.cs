using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayLight : MonoBehaviour
{
    private bool value, valueOut;
    public CircuitInputTrigger input;
    public SpriteRenderer sprite;

    void Update()
    {
        if (value != valueOut)
        {
            this.valueOut = value;
            // Set colour of light to value;
            Debug.Log("Light just output: " + this.value);
            if (this.value)
            {
                sprite.color = new Color(1, 0, 0, 1);
            }
            else
            {
                sprite.color = new Color(4, 1, 0, 0);
            }
        }
    }
}
