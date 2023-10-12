using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCircle : MonoBehaviour
{
  public float JumpForce = 10f;
  public Rigidbody2D ball;

    // Update is called once per frame
    void Update()
    {
         if ( Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
         {
            ball.velocity = Vector2.up * JumpForce;  
         }     
    }
}
