using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[Serializable]
public class Wire : MonoBehaviour
{
    private bool value, valueOut;
    private float x_mouseOffset, y_mouseOffset;
    private Vector3 startPosition;
    public bool dragging = false;
    public InputPort connectionPoint;
    public int wireID = 0;

    void Awake()
    {
        this.startPosition = this.transform.localPosition;
    }
    public void setValue(bool value)
    {
        this.value = value;
    }

    public void setConnectionPoint(InputPort connectionPoint)
    {
        this.connectionPoint = connectionPoint;
    }

    public InputPort getConnectionPoint()
    {
        return this.connectionPoint;
    }

    public void deleteConnectionPoint()
    {
        this.connectionPoint = null;
    }

    public void setWireID(int newID)
    {
        // NOTE: This method should only be used on game load.
        this.wireID = newID;
        GlobalVariables.incrementIDIfNecessary(newID);
    }

    void Update()
    {
        if (dragging)
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            this.gameObject.transform.localPosition = new Vector3(mousePosition.x - this.x_mouseOffset, mousePosition.y - this.y_mouseOffset, 0);
        }

        if (connectionPoint != null)
        {
            if (value != valueOut)
            {
                this.valueOut = value;
                connectionPoint.setValue(this.value);
            }
        }
    }

    private void OnMouseDown()
    {
        // If we are currently connected then disconnect tip (But keep reference to connectionPoint for possible reconnection)
        if (connectionPoint != null)
        {
            connectionPoint.RemoveWireTipChild();
        }

        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        this.dragging = true;
        this.x_mouseOffset = mousePosition.x - this.transform.localPosition.x;
        this.y_mouseOffset = mousePosition.y - this.transform.localPosition.y;
    }

    private void OnMouseUp()
    {
        dragging = false;

        // If after dropping the wire we never connected to a circuit then retract the wire.
        if (connectionPoint == null)
        {
            retractWire();
        }
        else
        {
            // Set the location of this wire tip
            var connectionPointLocation = this.connectionPoint.transform.position;
            this.gameObject.transform.position = connectionPointLocation;

            connectionPoint.SetWireTipAsChild(this.gameObject);

            // We need to immediately output our current value to the new connection:
            connectionPoint.setValue(this.valueOut);
        }
    }

    private void retractWire()
    {
        // NOTE: We are using localPosition here
        this.gameObject.transform.localPosition = this.startPosition;
    }
}
