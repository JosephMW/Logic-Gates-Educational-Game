using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPort : MonoBehaviour
{
    private bool value;
    public bool valueOut;
    public CircuitParent ownerCircuitParent;
    private Wire wireConnected;
    private GameObject wireConnectedTip;
    private Transform wireConnectedTipPreviousParentObj;

    public void setValue(bool value)
    {
        this.value = value;
    }

    void Update()
    {
        if (value != valueOut)
        {
            this.valueOut = value;
            ownerCircuitParent.updateValue();
        }
    }

    // Just overlapped a collider 2D
    private void OnTriggerEnter2D(Collider2D collider)
    {
        try
        {
            if (wireConnected == null)
            {
                var wireScript = collider.gameObject.GetComponentInParent<Wire>();
                if (wireScript.dragging)
                {
                    // Debug.Log(collider.gameObject.transform.parent.parent.name);
                    wireScript.setConnectionPoint(this);
                    this.wireConnected = wireScript;

                    Debug.Log(wireScript.gameObject.transform);

                    // set wiretip parent to this object
                    //this.wireConnectedTipPreviousParentObj = wireScript.gameObject.transform.parent;
                    //wireScript.gameObject.transform.parent = this.transform;
                }
            }
        }
        catch
        {
            //do nothing
        }
    }

    public void SetWireTipAsChild(GameObject wireTip)
    {
        this.wireConnectedTipPreviousParentObj = wireTip.transform.parent;
        this.wireConnectedTip = wireTip;

        wireTip.transform.parent = this.transform.parent;
    }

    public void RemoveWireTipChild()
    {
        if (wireConnectedTip != null && wireConnectedTipPreviousParentObj != null)
        {
            this.wireConnectedTip.transform.parent = this.wireConnectedTipPreviousParentObj;

            this.wireConnectedTipPreviousParentObj = null;
            this.wireConnectedTip = null;
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
        // We use a try block as accessing collider.gameObject.GetComponentInParent<Wire>() may be a null ref
        try
        {
            // if the object that left the collider is out connected wire and that wire is being dragged (The goal is decoupling) then decouple.
            if (wireConnected == collider.gameObject.GetComponentInParent<Wire>() && wireConnected.dragging)
            {
                wireConnected.deleteConnectionPoint();

                this.wireConnected = null;
            }
        }
        catch { }
    }
}
