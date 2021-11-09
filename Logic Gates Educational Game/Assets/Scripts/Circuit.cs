using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Circuit : CircuitParent
{
    // Update is called once per frame
    public override bool[] calculateOutputs()
    {
        // output is just the inputs (This circuit does nothing)
        return this.inputValues;
    }
}
