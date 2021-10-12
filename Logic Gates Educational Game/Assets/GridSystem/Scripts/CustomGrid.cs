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
                createBackgroundSquare(null, getPosition(x, y));
            }
        }
    }

    private Vector3 getPosition(int x, int y){
        float x_pos = x - (float)(this.width - 1)/(float)(2);
        float y_pos = y - (float)(this.height - 1)/(float)(2);
        // Debug.Log("x = " + x_pos + " y= " + y_pos);
        return new Vector3(x_pos, y_pos) * cellSize;
    }

    private void createBackgroundSquare(Transform parent, Vector3 localPosition){
        GameObject gameObject = new GameObject("Background square", typeof(SpriteRenderer));
        Transform transform = gameObject.transform;
        transform.SetParent(parent, false);
        transform.localPosition = localPosition;

        SpriteRenderer spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.drawMode = SpriteDrawMode.Sliced;
        Sprite customGridSquare = Resources.Load<Sprite>("Sprites/CustomGridSquare");
        spriteRenderer.sprite = customGridSquare;
        spriteRenderer.size = new Vector2 (0.95f * this.cellSize, 0.95f * this.cellSize);
    }
}
