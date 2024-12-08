using UnityEngine;
using UnityEngine.SceneManagement; // Import the SceneManagement namespace

public class SpikeBehavior : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // Check if the player collided
        {
            Debug.Log("Player hit a Spike!");
            SceneManager.LoadScene("GameOver"); // Load the GameOver scene
        }
    }
}
