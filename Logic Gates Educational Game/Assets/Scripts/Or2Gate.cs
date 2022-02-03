using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Or2Gate : CircuitParent
{
    public override bool[] calculateOutputs()
    {
        // output is first input || second input
        bool[] output = { inputValues[0] || inputValues[1] };
        return output;
    }
}
