using UnityEngine;
public class CollisionCheck : MonoBehaviour
{
    bool isDead = false;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obstacle") && !isDead)
        {
            isDead = true;
            Debug.Log("You've Lost!");
            // Stopping player movement
            GetComponent<PlayerMovement>().enabled = false;
        }

        else if (other.CompareTag("Goal") && !isDead)
        {
            Debug.Log("You've Won!");
        }
    }
}