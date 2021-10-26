using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayLight : MonoBehaviour
{
    private bool value, valueOut;
    public CircuitInputTrigger input;
    public SpriteRenderer sprite;
    private static Color onColor = new Color(1, 1, 0, 1);
    private static Color offColor = new Color(46f / 255f, 46f / 255f, 46f / 255f, 1);

    public void setValue(bool value)
    {
        this.value = value;
    }

    void Update()
    {
        if (value != valueOut)
        {
            this.valueOut = value;
            Debug.Log("Light just output: " + this.value);
            if (this.value)
            {
                sprite.color = onColor;
            }
            else
            {
                sprite.color = offColor;
            }
        }
    }
}
