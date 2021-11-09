using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

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

        if (calculatedOutputs != outputs.Select(output => output.valueOut).ToArray())
        {
            setOutputs(calculatedOutputs);
        }
    }

    public abstract bool[] calculateOutputs();
    public void setOutputs(bool[] newOutputValues)
    {
        for (int i = 0; i < outputs.Length; i++)
        {
            outputs[i].outputWire.setValue(newOutputValues[i]);
            outputs[i].valueOut = newOutputValues[i];
        }
    }
}
