using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //Reference to the player
    public Transform playerBall;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(playerBall.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, playerBall.position.y, transform.position.z);
        } 
    }
}
