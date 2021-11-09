using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CircuitParent : MonoBehaviour
{
    public (InputPort inputPort, bool value)[] inputs;
    public (Wire outputWire, bool valueOut)[] outputs;

    public void updateValue()
    {
        for (int i = 0; i < inputs.Length; i++)
        {
            inputs[i].value = inputs[i].inputPort.valueOut;
        }
    }

    // Update is called once per frame
    void Update()
    {
        bool[] calculatedOutputs = calculateOutputs();

        if (calculatedOutputs != outputs.Select(output => output.valueOut).ToList())
        {
            setOutput(calculatedOutputs);
        }
    }

    public abstract bool[] calculateOutputs();
    public void setOutputs(bool[] outputValues)
    {
        for (int i = 0; i < outputs.Length; i++)
        {
            outputs[i].outputWire.setValue(i);
            outputs[i].valueOut = outputValues[i];
        }
    }
}
