using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Circuit : MonoBehaviour
{
    private float x_startPos, y_startPos;
    private bool mouseDown = false;

    void Update()
    {
        if (mouseDown)
        {
            Vector3 mousePosition;
            mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

            this.gameObject.transform.localPosition = new Vector3(mousePosition.x - x_startPos, mousePosition.y - y_startPos, 0);
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

            x_startPos = mousePosition.x - this.transform.localPosition.x;
            y_startPos = mousePosition.y - this.transform.localPosition.y;
            mouseDown = true;
        }
    }

    private void OnMouseUp()
    {
        Debug.Log("Circuit OnMouseUp");
        mouseDown = false;
    }
}
