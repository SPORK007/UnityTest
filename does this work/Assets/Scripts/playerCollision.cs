using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "deathwall")
        {
            movement.enabled = false;

        }
    }
}