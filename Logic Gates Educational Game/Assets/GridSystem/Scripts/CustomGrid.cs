using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomGrid
{
    private int width;
    private int height;
    private int[,] gridArray;
    public CustomGrid(int width, int height){
        this.width=width;
        this.height=height;

        this.gridArray = new int[width, height];

        for (int x=0; x<width; x++){
            for (int y=0; y<height; y++){
                //Display empty grid square here.
                Debug.Log(x + " " + y);
            }
        }
    }

    private (int, int) getPosition(){
        return (0,0);
    }

    private TextMesh createBackgroundSquare(){
        GameObject gameObject = new GameObject("Background square", typeof(TextMesh));

        //more to come...
    }
}
