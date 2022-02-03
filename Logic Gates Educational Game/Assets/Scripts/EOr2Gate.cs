using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EOr2Gate : CircuitParent
{
    public override bool[] calculateOutputs()
    {
        // output is first input or second input but not both
        bool[] output = { inputValues[0] ^ inputValues[1] };
        return output;
    }
}
