using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomGrid : MonoBehaviour
{
    private int width;
    private int height;
    private bool[,] gridArray;
    private float cellSize;
    public Color BackgroundSquareColor;
    public Color BinSquareColor;

    void Awake()
    {
        this.width = 16;
        this.height = 9;
        this.cellSize = 1.11f;

        this.gridArray = new bool[width, height];

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                if (x == 0 && y == height - 1)
                {
                    this.gridArray[x, y] = true;
                    continue;
                }


                createBackgroundSquare(this.transform, convertGridArrayPositionToLocalPosition(x, y), (x == width - 1 && y == height - 1));
            }
        }
    }

    private Vector3 convertGridArrayPositionToLocalPosition(int x, int y)
    {
        float x_pos = x - (float)(this.width - 1) / (float)(2);
        float y_pos = y - (float)(this.height - 1) / (float)(2);
        return new Vector3(x_pos, y_pos) * cellSize;
    }

    private void createBackgroundSquare(Transform parent, Vector3 localPosition, bool IsTheBin)
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
        spriteRenderer.color = IsTheBin ? BinSquareColor : BackgroundSquareColor;
    }


    private (int x_arrayPosition, int y_arrayPosition) convertLocalPositionToGridArrayPosition(Vector3 localPosition)
    {
        Vector3 normalisedPosition = localPosition / this.cellSize;

        Vector3 offset = new Vector3((float)(this.width - 1) / (float)(2), (float)(this.height - 1) / (float)(2));

        normalisedPosition += offset;

        int x_arrayPosition = (int)System.Math.Round(normalisedPosition[0]);
        int y_arrayPosition = (int)System.Math.Round(normalisedPosition[1]);

        return (x_arrayPosition, y_arrayPosition);
    }

    public Vector3 placeElementInGrid(Vector3 proposedPosition, Vector3 startPosition)
    {
        // Based on proposedPosition, assign the element a position in the grid,
        // and return a Vector3 of the center of the gridPosition;
        // If the proposedPosition is taken, instead return startPosition;

        (int x, int y) arrayPosition = convertLocalPositionToGridArrayPosition(proposedPosition);

        if ((arrayPosition.x >= this.width)
            || (arrayPosition.x < 0)
            || (arrayPosition.y >= this.height)
            || (arrayPosition.y < 0))
        {
            // we are outside of the grid.
            return startPosition;
        }

        // If the selected position is the upper right square (The Bin):
        if (arrayPosition.x == this.width - 1 && arrayPosition.y == this.height - 1)
        {
            Debug.Log("Upper Right Corner");
            clearSquare(startPosition);
            return new Vector3(9999, 9999, 9999);
        }

        // If the current position is empty:
        if (this.gridArray[arrayPosition.x, arrayPosition.y] == false)
        {
            clearSquare(startPosition);

            this.gridArray[arrayPosition.x, arrayPosition.y] = true;

            Vector3 centerOfSquare = convertGridArrayPositionToLocalPosition(arrayPosition.x, arrayPosition.y);

            return centerOfSquare;
        }
        else
        {
            return startPosition;
        }
    }


    public void clearSquare(Vector3 localPosition)
    {
        (int x, int y) arrayPosition = convertLocalPositionToGridArrayPosition(localPosition);
        if ((arrayPosition.x >= this.width)
           || (arrayPosition.x < 0)
           || (arrayPosition.y >= this.height)
           || (arrayPosition.y < 0))
        {
            // we are outside of the grid.
            return;
        }
        this.gridArray[arrayPosition.x, arrayPosition.y] = false;
    }
}
