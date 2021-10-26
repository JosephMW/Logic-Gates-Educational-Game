using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public bool value = false;
    public Wire output;
    public SpriteRenderer sprite;

    void Update()
    {
        if (!this.value)
        {
            sprite.color = new Color(1, 0, 0, 1);
        }
        else
        {
            sprite.color = new Color(4, 1, 0, 0);
        }
        // this.value = !this.value;
    }
}
