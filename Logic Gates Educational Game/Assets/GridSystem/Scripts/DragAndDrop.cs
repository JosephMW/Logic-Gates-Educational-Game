using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragAndDrop : MonoBehaviour
{
    private float x_mouseOffset, y_mouseOffset;
    private Vector3 startPosition;
    private bool mouseDown = false;

    public CustomGrid customGrid;

    void Update()
    {
        if (mouseDown)
        {
            Vector3 mousePosition;
            mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

            this.gameObject.transform.localPosition = new Vector3(mousePosition.x - x_mouseOffset, mousePosition.y - y_mouseOffset, 0);
        }
    }

    private void OnMouseDown()
    {
        Debug.Log("Circuit OnMouseDown");
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition;
            mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

            this.startPosition = this.transform.localPosition;

            x_mouseOffset = mousePosition.x - this.transform.localPosition.x;
            y_mouseOffset = mousePosition.y - this.transform.localPosition.y;
            mouseDown = true;

            //NEED TO EMPTY SQUARE IN GRID ALSO
        }
    }

    private void OnMouseUp()
    {
        Debug.Log("Circuit OnMouseUp");
        mouseDown = false;

        Vector3 mousePosition;
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        if (customGrid != null)
        {
            Vector3 newPosition = customGrid.placeElementInGrid(new Vector3(mousePosition.x - x_mouseOffset, mousePosition.y - y_mouseOffset, 0));

            if (newPosition != new Vector3(-9999, -9999, -9999))
            {
                this.gameObject.transform.localPosition = newPosition;
            }
            else
            {
                this.gameObject.transform.localPosition = this.startPosition;
            }

        }
    }
}
