using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class And2Circuit : MonoBehaviour
{
    public Wire output;
    private bool value1, value2, valueOut;
    public CircuitInputTrigger input1;
    public CircuitInputTrigger input2;

    public void updateValue()
    {
        if (input1 != null)
        {
            this.value1 = input1.valueOut;
        }

        if (input2 != null)
        {
            this.value2 = input2.valueOut;
        }
    }

    // Update is called once per frame
    void Update()
    {
        bool newestOutput = calculateOutput(this.value1, this.value2);
        if (newestOutput != valueOut)
        {
            this.valueOut = newestOutput;
            output.setValue(newestOutput);
        }
    }

    private bool calculateOutput(bool value1, bool value2)
    {
        return value1 && value2;
    }
}
