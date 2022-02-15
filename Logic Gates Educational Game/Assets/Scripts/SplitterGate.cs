using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplitterGate : CircuitParent
{
    public override bool[] calculateOutputs()
    {
        // output is just the input
        bool[] output = { inputValues[0] };
        return output;
    }
}
