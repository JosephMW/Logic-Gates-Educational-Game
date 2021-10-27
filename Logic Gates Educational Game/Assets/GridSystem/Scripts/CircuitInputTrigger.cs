using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircuitInputTrigger : MonoBehaviour
{
    private bool value, valueOut;

    private Wire wireConnected;
    public Circuit ownerCircuit;
    public DisplayLight ownerLight;

    public void setValue(bool value)
    {
        this.value = value;
    }

    void Update()
    {
        if (value != valueOut)
        {
            this.valueOut = value;
            if (ownerCircuit != null)
            {
                ownerCircuit.setValue(this.value);
            }
            if (ownerLight != null)
            {
                ownerLight.setValue(this.value);
            }
        }
    }

    // Just overlapped a collider 2D
    private void OnTriggerEnter2D(Collider2D collider)
    {
        try
        {
            var wireScript = collider.gameObject.GetComponentInParent<Wire>();
            if (wireScript.dragging)
            {
                // WE ARE IN THE CORRECT STATE TO COUPLE WITH THIS INPUT WIRE:
                Debug.Log(collider.gameObject.transform.parent.parent.name);
                wireScript.setConnectionPoint(this);
                this.wireConnected = wireScript;
            }
        }
        catch
        {
            //do nothing
        }
    }

    // Overlapping a collider 2D
    private void OnTriggerStay2D(Collider2D collider)
    {
        //Do something
    }

    // Just stopped overlapping a collider 2D
    private void OnTriggerExit2D(Collider2D collider)
    {
        // Uncouple the wire from this CircuitInput Trigger.
        // Set value to false?
    }
}
