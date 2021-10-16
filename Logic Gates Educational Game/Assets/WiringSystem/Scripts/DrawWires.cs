using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DrawWires : MonoBehaviour
{
    private int lastWireCreated = 2;
    private bool dragging = false;

    public CustomGrid customGrid;

    void Update()
    {

    }

    private void OnMouseDown()
    {
        Debug.Log("onMouseDown");
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        // send this location to CustomGrid which will see if the current spot is vacant/
        // 1. if vacant we will create a new wire HERE - with unique identifier.
        // Then send the unique id to customGrid to mark it on the grid.
        // 2. If contains a wire we get the id of the wire from customGrid and then continue building said wire.
        // 3. If contains a circuit? We try to link wire to circuit somehow?

        int objectAtClickLocation = customGrid.queryGrid(mousePosition);

        switch (objectAtClickLocation)
        {
            // case -1 is used to represent we clicked outside the grid.
            case -1:
                Debug.Log("You clicked outside of the grid");
                return;
            // case 0 means grid empty
            case 0:
                Debug.Log("You clicked on an empty square");
                dragging = true;
                // Create new wire
                break;
            // case 1 means circuit at location.
            case 1:
                Debug.Log("You clicked on a circuit");
                // link new wire to circuit
                break;

            // case X means a circuit with unique identifier X is at the location.
            default:
                break;
                // continue building this wire.
        }
    }

    private void OnMouseUp()
    {
        Debug.Log("OnMouseUp");
    }

    private void createWire(int wireID)
    {

    }
}
