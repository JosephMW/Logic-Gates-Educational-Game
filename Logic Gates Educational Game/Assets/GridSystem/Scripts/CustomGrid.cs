using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomGrid
{
    private int width;
    private int height;
    private int[,] gridArray;
    private float cellSize;

    public CustomGrid(int width, int height, float cellSize){
        this.width=width;
        this.height=height;
        this.cellSize = cellSize;

        this.gridArray = new int[width, height];

        for (int x=0; x<width; x++){
            for (int y=0; y<height; y++){
                //Display empty grid square here.
                Debug.Log("x = " + x + " y= " + y + " Position= " + getPosition(x, y));
                createBackgroundSquare(null, getPosition(x, y), "x = " + x + " y= " + y);
            }
        }
    }

    private Vector3 getPosition(int x, int y){
        return new Vector3(x, y) * cellSize;
    }

    private void createBackgroundSquare(Transform parent, Vector3 localPosition, string text){
        GameObject gameObject = new GameObject("Background square", typeof(SpriteRenderer));
        Transform transform = gameObject.transform;
        transform.SetParent(parent, false);
        transform.localPosition = localPosition;

        // TextMesh textMesh = gameObject.GetComponent<TextMesh>();
        // textMesh.anchor = TextAnchor.MiddleCenter;
        
        // textMesh.text = text;
        // textMesh.fontSize = 15;
        // return textMesh;   

        SpriteRenderer spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.drawMode = SpriteDrawMode.Sliced;
        Sprite customGridSquare = Resources.Load<Sprite>("Sprites/CustomGridSquare");
        spriteRenderer.sprite = customGridSquare;
        spriteRenderer.size = new Vector2 (0.95f * this.cellSize, 0.95f * this.cellSize);
        // return textMesh;   
    }
}
