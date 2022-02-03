using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Multiplexer : CircuitParent
{
    public override bool[] calculateOutputs()
    {
        // output is first input or second input but not both
        bool[] output = { inputValues[2] ? inputValues[1] : inputValues[0] };
        return output;
    }
}
