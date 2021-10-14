using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomGrid : MonoBehaviour
{
    private int width;
    private int height;
    private bool[,] gridArray;
    private float cellSize;

    void Awake()
    {
        this.width = 6;
        this.height = 8;
        this.cellSize = 2f;

        this.gridArray = new bool[width, height];

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                createBackgroundSquare(null, getPosition(x, y));
            }
        }
    }

    private Vector3 getPosition(int x, int y)
    {
        float x_pos = x - (float)(this.width - 1) / (float)(2);
        float y_pos = y - (float)(this.height - 1) / (float)(2);
        // Debug.Log("x = " + x_pos + " y= " + y_pos);
        return new Vector3(x_pos, y_pos) * cellSize;
    }

    private void createBackgroundSquare(Transform parent, Vector3 localPosition)
    {
        GameObject gameObject = new GameObject("Background square", typeof(SpriteRenderer));
        Transform transform = gameObject.transform;
        transform.SetParent(parent, false);
        transform.localPosition = localPosition;

        SpriteRenderer spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.drawMode = SpriteDrawMode.Sliced;
        Sprite customGridSquare = Resources.Load<Sprite>("Sprites/CustomGridSquare");
        spriteRenderer.sprite = customGridSquare;
        spriteRenderer.size = new Vector2(0.95f * this.cellSize, 0.95f * this.cellSize);
    }

    public Vector3 placeElementInGrid(Vector3 proposedPosition)
    {
        // Based on proposedPosition, assign the element a position in the grid,
        // and return a Vector3 of the center of the gridPosition;

        Vector3 normalisedPosition = proposedPosition / this.cellSize;

        Vector3 offset = new Vector3((float)(this.width - 1) / (float)(2), (float)(this.height - 1) / (float)(2));

        normalisedPosition += offset;

        int x_arrayPosition = (int)System.Math.Round(normalisedPosition[0]);
        int y_arrayPosition = (int)System.Math.Round(normalisedPosition[1]);

        if (!this.gridArray[x_arrayPosition, y_arrayPosition])
        {
            this.gridArray[x_arrayPosition, y_arrayPosition] = true; // true signifies slot taken.

            Vector3 centerOfSquare = getPosition(x_arrayPosition, y_arrayPosition);
            return centerOfSquare;
        }
        return new Vector3(-9999, -9999, -9999);
    }

    public void clearSquare(int x_pos, int y_pos)
    {
        this.gridArray[x_pos, y_pos] = false;
    }
}
