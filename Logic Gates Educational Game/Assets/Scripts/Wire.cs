using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Wire : MonoBehaviour
{
    private bool value, valueOut;
    private float x_mouseOffset, y_mouseOffset;
    private Vector3 startPosition;
    public bool dragging = false;
    private InputPort connectionPoint;

    public void setValue(bool value)
    {
        this.value = value;
    }

    public void setConnectionPoint(InputPort connectionPoint)
    {
        this.connectionPoint = connectionPoint;
    }

    public void deleteConnectionPoint()
    {
        this.connectionPoint = null;
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
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        this.startPosition = this.transform.position - this.transform.localPosition;

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
            var connectionPointLocation = this.connectionPoint.transform.position;
            this.gameObject.transform.position = connectionPointLocation;
        }
    }

    private void retractWire()
    {
        this.gameObject.transform.position = this.startPosition;
    }
}
