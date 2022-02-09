using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : CircuitParent
{
    public bool value = false;

    public SpriteRenderer sprite;
    public Color onColor;
    public Color offColor;

    void OnMouseDown()
    {
        if (!this.value)
        {
            sprite.color = onColor;
        }
        else
        {
            sprite.color = offColor;
        }

        this.value = !this.value;
    }

    public override bool[] calculateOutputs()
    {
        // output is first input && second input
        bool[] output = { this.value };
        return output;
    }
}
