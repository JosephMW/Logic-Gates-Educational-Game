using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotGate : CircuitParent
{
    public override bool[] calculateOutputs()
    {
        // output is inverse of the first input 
        bool[] output = { !inputValues[0] };
        return output;
    }
}
