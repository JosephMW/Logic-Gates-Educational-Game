using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class InputPort : MonoBehaviour
{
    private bool value;
    public bool valueOut;

    public CircuitParent ownerCircuitParent;

    private Wire wireConnected;
    private GameObject wireConnectedTip;
    private Transform wireConnectedTipPreviousParentObj;

    public int inputPortID = 0;

    public void setValue(bool value)
    {
        this.value = value;
    }

    public void setInputPortID(int newID)
    {
        // NOTE: This method should only be used on game load.
        this.inputPortID = newID;
        GlobalVariables.incrementIDIfNecessary(newID);
    }

    public void setWireConnected(Wire wire)
    {
        this.wireConnected = wire;
    }

    void Update()
    {
        if (value != valueOut)
        {
            this.valueOut = value;
            ownerCircuitParent.updateValue();
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        // We use a try block as accessing collider.gameObject.GetComponentInParent<Wire>() may be a null ref
        try
        {
            if (wireConnected == null)
            {
                Wire wireScript = collider.gameObject.GetComponentInParent<Wire>();
                if (wireScript.dragging && (wireScript.getConnectionPoint() == null) && (0 == (ownerCircuitParent.outputWires.Where(wire => wire.wireID == wireScript.wireID)).Count()))
                {
                    wireScript.setConnectionPoint(this);
                    this.wireConnected = wireScript;
                }
            }
        }
        catch { }
    }
    private void OnTriggerStay2D(Collider2D collider)
    {
        // We use a try block as accessing collider.gameObject.GetComponentInParent<Wire>() may be a null ref
        try
        {
            if (wireConnected == null)
            {
                Wire wireScript = collider.gameObject.GetComponentInParent<Wire>();
                if (wireScript.dragging && (wireScript.getConnectionPoint() == null) && (0 == (ownerCircuitParent.outputWires.Where(wire => wire.wireID == wireScript.wireID)).Count()))
                {
                    wireScript.setConnectionPoint(this);
                    this.wireConnected = wireScript;
                }
            }
        }
        catch { }
    }
    public void SetWireTipAsChild(GameObject wireTip)
    {
        this.wireConnectedTipPreviousParentObj = wireTip.transform.parent;
        this.wireConnectedTip = wireTip;

        wireTip.transform.parent = this.transform.parent;

        // While the wire is connected we want to disable the box collider, so that other wires trying to connect do not cause complications
        this.GetComponent<Collider2D>().enabled = false;
    }

    public void RemoveWireTipChild()
    {
        if (wireConnectedTip != null && wireConnectedTipPreviousParentObj != null)
        {
            this.wireConnectedTip.transform.parent = this.wireConnectedTipPreviousParentObj;

            this.wireConnectedTipPreviousParentObj = null;
            this.wireConnectedTip = null;

            // While the wire is connected we want to disable the box collider, so that other wires trying to connect do not cause complications
            this.GetComponent<Collider2D>().enabled = true;

            // We need to revert our value to false now that the connection has been broken:
            this.setValue(false);
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        // We use a try block as accessing collider.gameObject.GetComponentInParent<Wire>() may be a null ref
        try
        {
            // if the object that left the collider is our connected wire and that wire is being dragged (The goal is decoupling) then decouple.
            if (wireConnected == collider.gameObject.GetComponentInParent<Wire>() && wireConnected.dragging)
            {
                deleteConnectionWithWire(retractWire: false);
            }
        }
        catch { }
    }

    public void deleteConnectionWithWire(bool retractWire)
    {
        if (wireConnected != null)
        {
            RemoveWireTipChild();
            wireConnected.deleteConnectionPoint();
            if (retractWire)
            {
                wireConnected.retractWire();
            }
            this.wireConnected = null;
        }
    }
}
