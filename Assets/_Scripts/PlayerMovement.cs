using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField]private float speed = 1f;
    [SerializeField]private float jumpForce = 1f;
    GroundCheck groundCheck;
    Rigidbody2D body;
    Collider2D col;
    bool isGrounded;
    float inputTimer;
    [Range(0,1)]
    [SerializeField]private float verticalCut;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
        groundCheck= new GroundCheck(col);
        inputTimer=0;
    }

    private void FixedUpdate()
    {
        isGrounded = groundCheck.IsOnGround();
    }
    // Update is called once per frame
    void Update()
    {
        HandleMovement();
        HandleJumping();
       
    }
    private void HandleMovement()
    {
        float axis = Input.GetAxisRaw("Horizontal");
        body.velocity = new Vector2(speed*axis,body.velocity.y);
    }
    private void HandleJumping()
    {
        if(Input.GetButtonDown("Vertical"))
        {
            Debug.Log(isGrounded);
            if(isGrounded)
            {
               Jump();
            }
            else
            {
                inputTimer=.2f;
            }
        }
         if(inputTimer>0){
            if (isGrounded)
            {
                Jump();
                inputTimer=0;
            }
            inputTimer-=Time.deltaTime;
        }
        if (Input.GetButtonUp("Vertical"))
        {
            if(body.velocity.y > 0) body.velocity = new Vector2(body.velocity.x,body.velocity.y * verticalCut);
        }

    }
    private void Jump()
    {
           
         body.AddForce(Vector2.up*jumpForce,ForceMode2D.Impulse);
    }
   

   
    private void OnDrawGizmos()
    {
        
        if (col != null)
        {
            Vector2 left = col.bounds.min;
        Vector2 right = new Vector2(col.bounds.max.x,col.bounds.min.y);
            Gizmos.DrawLine(left,left+Vector2.down*.15f);
        Gizmos.DrawLine(right,right+Vector2.down*.15f);
        }
        
    }
}
