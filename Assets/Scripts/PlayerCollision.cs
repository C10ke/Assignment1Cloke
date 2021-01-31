using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;

    // This function runs when the player hits another ojbect.
    // We get infomation about the collision can call it "collisionInfo"
    void OnCollisionEnter(Collision collisionInfo )
    {
        // Check if the object we collided with has a tag called "Obstacle".
        if (collisionInfo.collider.tag == "Obstacle")
        {
            // Tests collision on console if player hits an "Obstacle".
            /*Debug.Log("We hit a obstacle!");*/
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }

    }

}
