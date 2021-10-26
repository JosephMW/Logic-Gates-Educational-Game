using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircuitInputTrigger : MonoBehaviour
{
    //Just overlapped a collider 2D
    private void OnTriggerEnter2D(Collider2D collider)
    {
        try
        {
            var wireScript = collider.gameObject.GetComponentInParent<Wire>();
            if (wireScript.dragging)
            {
                Debug.Log("We are dragging a wire on this connection");
                Debug.Log("Name of circuit that just overlapped:");
                Debug.Log(collider.gameObject.transform.parent.parent.name);
            }
        }
        catch
        {
            //do nothing
        }
        // collider.gameObject.transform.position = this.gameObject.transform.position;
    }

    //Overlapping a collider 2D
    private void OnTriggerStay2D(Collider2D collider)
    {
        //Do something
    }

    //Just stop overlapping a collider 2D
    private void OnTriggerExit2D(Collider2D collider)
    {
        //Do something
    }
}
