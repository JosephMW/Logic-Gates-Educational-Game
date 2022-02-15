using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splitter2Gate : CircuitParent
{
    public override bool[] calculateOutputs()
    {
        // output is just the input twice
        bool[] output = { inputValues[0], inputValues[0] };
        return output;
    }
}
