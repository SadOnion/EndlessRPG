using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdjustRotationToCursor : MonoBehaviour
{
    public float offset;
    

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 dir = mousePos - (Vector2)transform.position;
        dir.Normalize();
        float angle = Vector2.Angle(Vector2.right,dir);
        if(transform.position.y > mousePos.y) angle*=-1;
        transform.rotation = Quaternion.Euler(0,0,angle+offset);
    }
}
