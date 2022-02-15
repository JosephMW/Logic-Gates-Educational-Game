using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splitter4Gate : CircuitParent
{
    public override bool[] calculateOutputs()
    {
        // output is just the input 4 times
        bool[] output = { inputValues[0], inputValues[0], inputValues[0], inputValues[0] };
        return output;
    }
}
