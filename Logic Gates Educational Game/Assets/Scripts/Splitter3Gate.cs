using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splitter3Gate : CircuitParent
{
    public override bool[] calculateOutputs()
    {
        // output is just the input 3 times
        bool[] output = { inputValues[0], inputValues[0], inputValues[0] };
        return output;
    }
}
