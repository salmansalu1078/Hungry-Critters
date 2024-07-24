using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private int collisionCount = 0; // Counter for collisions

    // This method is called when the collider enters a trigger collider
    void OnTriggerEnter(Collider other)
    {
        collisionCount++; // Increment the collision counter
        Destroy(gameObject);
        // Check if the collision count has reached 2
        if (collisionCount >= 2)
        {
            // Destroy this game object
            Destroy(other.gameObject); // Destroy the other game object
        }
    }
}
