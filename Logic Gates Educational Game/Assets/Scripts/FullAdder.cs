using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullAdder : CircuitParent
{
    public override bool[] calculateOutputs()
    {
        // output is first input or second input but not both
        int count = 0;
        for (int i = 0; i < 3; i++)
        {
            if (inputValues[i])
            {
                count++;
            }
        }
        bool[] output = { (count == 1 || count == 3), (count >= 2) };
        return output;
    }
}
