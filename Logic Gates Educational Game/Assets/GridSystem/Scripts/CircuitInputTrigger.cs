using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircuitInputTrigger : MonoBehaviour
{
    private bool value, valueOut;

    private Wire wireConnected;
    public Circuit ownerCircuit;

    public void setValue(bool value)
    {
        this.value = value;
    }

    void Update()
    {
        if (value != valueOut)
        {
            this.valueOut = value;
            ownerCircuit.setValue(this.value);
            Debug.Log("CircuitInput just output: " + this.value);
        }
    }
    //Just overlapped a collider 2D
    private void OnTriggerEnter2D(Collider2D collider)
    {
        try
        {
            var wireScript = collider.gameObject.GetComponentInParent<Wire>();
            if (wireScript.dragging)
            {
                // WE ARE IN THE CORRECT STATE TO COUPLE WITH THIS INPUT WIRE:
                Debug.Log("We are dragging a wire on this connection");
                Debug.Log("Name of circuit that just overlapped:");
                Debug.Log(collider.gameObject.transform.parent.parent.name);
                wireScript.setConnectionPoint(this);
                this.wireConnected = wireScript;
            }
        }
        catch
        {
            //do nothing
        }
        // collider.gameObject.transform.position = this.gameObject.transform.position;
    }

    //Overlapping a collider 2D
    private void OnTriggerStay2D(Collider2D collider)
    {
        //Do something
    }

    //Just stop overlapping a collider 2D
    private void OnTriggerExit2D(Collider2D collider)
    {
        //Do something
        // Call retract() on the wire that is connected
    }
}
