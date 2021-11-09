using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public abstract class CircuitParent : MonoBehaviour
{
    public InputPort[] inputPorts;
    protected bool[] inputValues;
    public Wire[] outputWires;
    protected bool[] outputValues;

    public void updateValue()
    {
        for (int i = 0; i < this.inputPorts.Length; i++)
        {
            this.inputValues[i] = this.inputPorts[i].valueOut;
        }
    }

    // Update is called once per frame
    void Update()
    {
        bool[] calculatedOutputs = calculateOutputs();

        if (calculatedOutputs != outputValues)
        {
            setOutputs(calculatedOutputs);
        }
    }

    public abstract bool[] calculateOutputs();

    public void setOutputs(bool[] newOutputValues)
    {
        for (int i = 0; i < outputWires.Length; i++)
        {
            outputWires[i].setValue(newOutputValues[i]);
            outputValues[i] = newOutputValues[i];
        }
    }
}
