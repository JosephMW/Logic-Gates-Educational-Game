using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class And2Circuit : MonoBehaviour
{
    public InputPort input1;
    private bool value1;
    public InputPort input2;
    private bool value2;
    public Wire output;
    public bool valueOut;

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
        if (newestOutput != valueOut && output != null)
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
