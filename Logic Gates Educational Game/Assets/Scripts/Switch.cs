using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public bool value = false;
    public Wire output;
    public SpriteRenderer sprite;
    private static Color onColor = new Color(1, 1, 0, 1);
    private static Color offColor = new Color(46f / 255f, 46f / 255f, 46f / 255f, 1);

    void OnMouseDown()
    {
        if (!this.value)
        {
            sprite.color = onColor;
        }
        else
        {
            sprite.color = offColor;
        }
        output.setValue(!this.value);
        this.value = !this.value;
    }
}
