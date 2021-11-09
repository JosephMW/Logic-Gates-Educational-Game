using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayLight : CircuitParent
{
    public SpriteRenderer sprite;
    private static Color onColor = new Color(1, 1, 0, 1);
    private static Color offColor = new Color(46f / 255f, 46f / 255f, 46f / 255f, 1);

    // Here we override the Update method so that we can change the sprite color
    protected override void Update()
    {
        bool[] calculatedOutputs = calculateOutputs();

        if (calculatedOutputs != outputValues)
        {
            setOutputs(calculatedOutputs);
            if (calculatedOutputs[0])
            {
                sprite.color = onColor;
            }
            else
            {
                sprite.color = offColor;
            }
        }
    }
    public override bool[] calculateOutputs()
    {
        // This circuit is simple and passes through the single input value
        bool[] output = { inputValues[0] };
        return output;
    }
}
