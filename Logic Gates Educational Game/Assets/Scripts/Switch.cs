using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : CircuitParent
{
    public bool value = false;

    public SpriteRenderer sprite;
    private static Color onColor = new Color(1, 1, 0, 1);
    private static Color offColor = new Color(46f / 255f, 46f / 255f, 46f / 255f, 1);

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
