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

    void Start()
    {
        // Instantiate the value arrays to have length matching their inputs/outputs
        inputValues = new bool[inputPorts.Length];
        outputValues = new bool[outputWires.Length];
    }

    public void updateValue()
    {
        for (int i = 0; i < this.inputPorts.Length; i++)
        {
            // Debug.Log("Inside CircuitParent updateValue, here is connected port: ");
            // Debug.Log(this.inputPorts[i].gameObject.transform.name);
            this.inputValues[i] = this.inputPorts[i].valueOut;
            // Debug.Log("Inside CircuitParent updateValue END");
        }
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        bool[] calculatedOutputs = calculateOutputs();

        if (calculatedOutputs != outputValues)
        {
            // Debug.Log("CircuitParent: Update - calculatedoutputs dont match previous outputs");
            setOutputs(calculatedOutputs);
        }
    }

    public abstract bool[] calculateOutputs();

    public void setOutputs(bool[] newOutputValues)
    {
        // Debug.Log("CircuitParent: Setting outputs now...");
        for (int i = 0; i < outputWires.Length; i++)
        {
            outputWires[i].setValue(newOutputValues[i]);
            outputValues[i] = newOutputValues[i];
        }
    }
}
