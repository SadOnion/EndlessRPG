using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartVelocity : MonoBehaviour
{
    public float speed;
    Rigidbody2D body;
    // Start is called before the first frame update
    void Start()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 dir = mousePos - (Vector2)transform.position;
        dir.Normalize();

        body = GetComponent<Rigidbody2D>();

        body.velocity = dir*speed;
    }

    
}
