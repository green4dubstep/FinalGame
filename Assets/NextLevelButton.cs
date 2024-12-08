using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    // Load the next level based on the current scene index
    public void LoadNextLevel()
    {
    SceneManager.LoadScene("Level2");
    }
}
