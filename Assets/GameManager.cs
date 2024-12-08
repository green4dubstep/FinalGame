using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverScreen; // Assign a UI Game Over screen here in the Inspector.

    // Called when the player dies
    public void GameOver()
    {
        Debug.Log("Game Over!");

        // Activate the game over screen if assigned
        if (gameOverScreen != null)
        {
            gameOverScreen.SetActive(true);
        }

        // Optionally, stop the game or reload the scene
        // Time.timeScale = 0; // Pause the game
    }

    // Restart the game by reloading the current scene
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Quit the application
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game Quit!"); // Only visible in the Unity Editor
    }
}
