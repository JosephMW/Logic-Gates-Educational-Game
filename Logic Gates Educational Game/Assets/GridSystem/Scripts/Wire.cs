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
    private Vector3 connectionPointLocation;

    public void setValue(bool value)
    {
        this.value = value;
    }

    public void setConnectionPoint(CircuitInputTrigger connectionPoint)
    {
        this.connectionPoint = connectionPoint;

        var connectionPointLctn = connectionPoint.transform.position + new Vector3(-0.1f, 0, 0);
        this.connectionPointLocation = connectionPointLctn;

        float distance = Vector2.Distance(startPosition, connectionPointLctn);
        wireEnd.transform.localScale = new Vector3(distance, wireEnd.transform.localScale.y, 0);
        float angle = Mathf.Atan((connectionPointLctn.y - startPosition.y) / (connectionPointLctn.x - startPosition.x));
        angle = (angle * 180) / Mathf.PI;
        wireEnd.transform.eulerAngles = new Vector3(0, 0, angle);
        wireEnd.transform.localPosition = (connectionPointLctn - startPosition) / 2;
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

        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        this.gameObject.transform.localPosition = new Vector3(mousePosition.x - this.x_mouseOffset, mousePosition.y - this.y_mouseOffset, 0);
        float distance = Vector2.Distance(startPosition, mousePosition);

        // If after dropping the wire we never connected to a circuit then retract the wire.
        if (connectionPoint == null)
        {
            retractWire();
        }
        else
        {
            this.gameObject.transform.position = this.connectionPointLocation;
        }
    }

    private void retractWire()
    {
        this.gameObject.transform.position = this.startPosition;
        wireEnd.transform.localScale = new Vector3(0, wireEnd.transform.localScale.y, 0);
        wireEnd.transform.localPosition = this.startPosition;
    }
}
