using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireBody : MonoBehaviour
{
    public GameObject WireBase;
    public GameObject WireTip;
    void Update()
    {
        // Set WireBody length
        float distance = Vector2.Distance(WireBase.transform.position, WireTip.transform.position);
        this.transform.localScale = new Vector3(distance, this.transform.localScale.y, 0);

        // Set WireBody angle
        float angle = Mathf.Atan((WireTip.transform.position.y - WireBase.transform.position.y) / (WireTip.transform.position.x - WireBase.transform.position.x));
        angle = (angle * 180) / Mathf.PI;
        this.transform.eulerAngles = new Vector3(0, 0, angle);

        // Set WireBody position
        this.transform.position = 0.5f * (WireTip.transform.position + WireBase.transform.position);
    }
}
