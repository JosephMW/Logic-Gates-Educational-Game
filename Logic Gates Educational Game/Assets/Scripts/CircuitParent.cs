using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public abstract class CircuitParent : MonoBehaviour
{
    public InputPort[] inputPorts;
    protected bool[] inputValues;
    public Wire[] outputWires;
    protected bool[] outputValues;

    public int circuitID = 0;

    void Start()
    {
        // Instantiate the value arrays to have length matching their inputs/outputs
        inputValues = new bool[inputPorts.Length];
        outputValues = new bool[outputWires.Length];

        circuitID = GlobalVariables.getID();
        for (int i = 0; i < inputPorts.Length; i++)
        {
            inputPorts[i].inputPortID = GlobalVariables.getID();
        }
        for (int i = 0; i < outputWires.Length; i++)
        {
            outputWires[i].wireID = GlobalVariables.getID();
        }
    }

    public void updateValue()
    {
        for (int i = 0; i < this.inputPorts.Length; i++)
        {
            this.inputValues[i] = this.inputPorts[i].valueOut;
        }
    }

    // Update is called once per frame
    protected virtual void Update()
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
