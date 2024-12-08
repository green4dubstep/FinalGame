using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Called when the Start button is clicked
    public void StartGame()
    {
        // Load the main game scene (replace "GameScene" with your actual scene name)
        SceneManager.LoadScene("SampleScene");
    }

    // Called when the Quit button is clicked
    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit(); // Only works in a built application
    }
     public void LevelSelector()
    {
       SceneManager.LoadScene("LevelSelector");
    }
}
