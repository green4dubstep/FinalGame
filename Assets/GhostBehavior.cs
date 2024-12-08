using UnityEngine;
using UnityEngine.SceneManagement; // Import the SceneManagement namespace

public class GhostBehavior : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // Check if the player collided
        {
            Debug.Log("Player hit a ghost!");
            SceneManager.LoadScene("GameOver"); // Load the GameOver scene
        }
    }
}
