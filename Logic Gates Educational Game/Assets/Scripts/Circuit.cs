using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circuit : MonoBehaviour
{
    private bool value, valueOut;
    public Wire output;
    public InputPort input;

    public void updateValue()
    {
        this.value = input.valueOut;
    }

    // Update is called once per frame
    void Update()
    {
        if (value != valueOut)
        {
            this.valueOut = value;
            output.setValue(this.value);
        }
    }
}
