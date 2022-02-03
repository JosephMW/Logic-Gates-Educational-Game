using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassThroughGate : CircuitParent
{
    public override bool[] calculateOutputs()
    {
        // output is just the inputs (This circuit does nothing)
        return this.inputValues;
    }
}
