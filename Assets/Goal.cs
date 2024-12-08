using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the player touched the goal
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Level Complete!");
            SceneManager.LoadScene("LevelComplete"); // Load the Level Complete scene
        }
    }
}
