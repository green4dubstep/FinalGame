using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the player touched the goal
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Level Complete!");
            SceneManager.LoadScene("Level3"); // Load the Level Complete scene
        }
    }
}
