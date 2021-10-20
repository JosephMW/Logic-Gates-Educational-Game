using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragAndDrop : MonoBehaviour
{
    private float x_mouseOffset, y_mouseOffset;
    private Vector3 startPosition;
    private bool dragging = false;

    public CustomGrid customGrid;

    void Start(){
        // center on underlying grid on start
        if (customGrid != null)
        {
            Vector3 newPosition = customGrid.placeElementInGrid(this.transform.localPosition, this.transform.localPosition);

            this.gameObject.transform.localPosition = newPosition;
        }
    }

    void Update()
    {
        if (dragging)
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

            this.gameObject.transform.localPosition = new Vector3(mousePosition.x - x_mouseOffset, mousePosition.y - y_mouseOffset, 0);
        }
    }

    private void OnMouseDown()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        // Set the start position and mouseOffset for later use. Also set dragging true.
        this.startPosition = this.transform.localPosition;

        this.x_mouseOffset = mousePosition.x - this.transform.localPosition.x;
        this.y_mouseOffset = mousePosition.y - this.transform.localPosition.y;
        this.dragging = true;
    }

    private void OnMouseUp()
    {
        dragging = false;

        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        if (customGrid != null)
        {
            Vector3 newPosition = customGrid.placeElementInGrid(new Vector3(mousePosition.x - x_mouseOffset, mousePosition.y - y_mouseOffset, 0), this.startPosition);

            this.gameObject.transform.localPosition = newPosition;
        }
    }
}
