using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCircle : MonoBehaviour
{
  public float JumpForce = 10f;
  public Rigidbody2D ball ;
  public string ballColor = "Yellow"; 
  public SpriteRenderer ballSpriteRenderer;
	
  public Color colorCyan;
	public Color colorYellow;
	public Color colorMagenta;
	public Color colorPink;
  
    void Start()
    {
      ball.velocity = Vector2.up * JumpForce;
      setRandomColorForBall();
    }

    // Update is called once per frame
    void Update()
    { 
        // Moves ball up when mouse is clicked or spacebar is down
         if ( Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
         {
            ball.velocity = Vector2.up * JumpForce;  
         }     
    }

   void OnTriggerEnter2D ( Collider2D col){
      if ( col.tag != ballColor)
      {
        Debug.Log("GAME OVER");
      }
     
    }

 
    void setRandomColorForBall()
    {
       int index = Random.Range(0, 4); 

       switch (index)
       {
        case 0:
          ballColor = "Yellow";
          ballSpriteRenderer.color =  colorYellow;
          break;
        case 1:
          ballColor = "Green";
          ballSpriteRenderer.color =  colorMagenta;
          break;
        case 2:
          ballColor = "Blue";
          ballSpriteRenderer.color = colorCyan;
          break;
        case 3:
          ballColor = "Pink";
          ballSpriteRenderer.color = colorPink;
          break;

       } 
    }
}
