using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Circuit : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private Vector3 position;
    private int x_customGridPosition, y_customGridPosition;
    public CustomGrid myGrid; // This shouldnt be here

    // next two are from tutorial
    private Canvas canvas;
    private GraphicRaycaster graphicRaycaster;

    public Circuit(Vector3 initialPosition)
    {
        this.position = initialPosition;
        renderCircuit(null, initialPosition);
    }
    public Circuit Init(Vector3 initialPosition)
    {
        return new Circuit(initialPosition);
    }

    private void renderCircuit(Transform parent, Vector3 localPosition)
    {
        GameObject gameObject = new GameObject("Circuit", typeof(SpriteRenderer));
        Transform transform = gameObject.transform;
        transform.SetParent(parent, false);
        transform.localPosition = localPosition;

        SpriteRenderer spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.drawMode = SpriteDrawMode.Sliced;
        Sprite circuit = Resources.Load<Sprite>("Sprites/Circuit");
        spriteRenderer.sprite = circuit;
        spriteRenderer.size = new Vector2(5f, 5f);
        spriteRenderer.color = Color.blue;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Began dragging");
        // Start moving object from the beginning!
        transform.localPosition += new Vector3(eventData.delta.x, eventData.delta.y, 0) / transform.lossyScale.x;

        myGrid.clearSquare(this.x_customGridPosition, this.y_customGridPosition);
        // Remove from position inside CustomGrid; 
        // update position;

        if (!canvas)
        {
            canvas = GetComponentInParent<Canvas>();
            graphicRaycaster = canvas.GetComponent<GraphicRaycaster>();
        }
        // Change parent of our item to the canvas.
        transform.SetParent(canvas.transform, true);
        // And set it as last child to be rendered on top of UI.
        transform.SetAsLastSibling();
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Mid drag");
        transform.localPosition += new Vector3(eventData.delta.x, eventData.delta.y, 0) / transform.lossyScale.x;
        //update position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("Dropped");
        // Get current position;
        Vector3 currentPosition = new Vector3(3, 4);

        // Place as element inside CustomGrid array;
        this.position = myGrid.placeElementInGrid(currentPosition);
    }
}
