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
                Debug.Log("CircuitOutput(Wire) just output: " + this.value);
            }
            // continuously output the value on this wire
        }
    }

    private void OnMouseDown()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        if (this.startPosition == new Vector3(0, 0, 0))
        {
            this.startPosition = this.transform.position;
        }
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
    }
}
