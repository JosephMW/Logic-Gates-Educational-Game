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
    public GameObject wireEnd;

    private CircuitInputTrigger connectionPoint;

    public void setValue(bool value)
    {
        this.value = value;
    }

    public void setConnectionPoint(CircuitInputTrigger connectionPoint)
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
            float distance = Vector2.Distance(startPosition, mousePosition);
            wireEnd.transform.localScale = new Vector3(distance, wireEnd.transform.localScale.y, 0);
            float angle = Mathf.Atan((mousePosition.y - startPosition.y) / (mousePosition.x - startPosition.x));
            angle = (angle * 180) / Mathf.PI;
            wireEnd.transform.eulerAngles = new Vector3(0, 0, angle);
            wireEnd.transform.localPosition = new Vector3(-(mousePosition.x - this.x_mouseOffset) / 2, -(mousePosition.y - this.y_mouseOffset) / 2, 0);
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
            var connectionPointLocation = this.connectionPoint.transform.position + new Vector3(-0.1f, 0, 0);

            this.gameObject.transform.position = connectionPointLocation;

            float distance = Vector2.Distance(this.startPosition, connectionPointLocation);
            wireEnd.transform.localScale = new Vector3(distance, wireEnd.transform.localScale.y, 0);
            float angle = Mathf.Atan((connectionPointLocation.y - startPosition.y) / (connectionPointLocation.x - startPosition.x));
            angle = (angle * 180) / Mathf.PI;
            wireEnd.transform.eulerAngles = new Vector3(0, 0, angle);
            wireEnd.transform.position = (connectionPointLocation + startPosition) / 2;
        }
    }

    private void retractWire()
    {
        this.gameObject.transform.position = this.startPosition;
        wireEnd.transform.localScale = new Vector3(0, wireEnd.transform.localScale.y, 0);
        wireEnd.transform.localPosition = this.startPosition;
    }
}
