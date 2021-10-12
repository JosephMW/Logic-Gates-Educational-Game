using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circuit : MonoBehaviour
{
    private Vector3 position;

    public Circuit(Vector3 initialPosition){
        this.position = initialPosition;
        renderCircuit(null, initialPosition);
    }

    private void renderCircuit(Transform parent, Vector3 localPosition){
        GameObject gameObject = new GameObject("Circuit", typeof(SpriteRenderer));
        Transform transform = gameObject.transform;
        transform.SetParent(parent, false);
        transform.localPosition = localPosition;

        SpriteRenderer spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.drawMode = SpriteDrawMode.Sliced;
        Sprite circuit = Resources.Load<Sprite>("Sprites/Circuit");
        spriteRenderer.sprite = circuit;
        spriteRenderer.size = new Vector2 (5f, 5f);
        spriteRenderer.color = Color.blue;
    }

    private void onDrag(){
        // Remove from position inside CustomGrid; 
        // update position;
    }

    private void whileDragging(){
        //update position;
    }

    private void onDrop(){
        // Get current position;
        Vector3 currentPosition = new Vector3(3,4);

        // Place as element inside CustomGrid array;
        this.position = myGrid.placeElementInGrid(currentPosition);
    }
}
