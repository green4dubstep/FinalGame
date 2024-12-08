using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager1 : MonoBehaviour
{
    // Load the next level based on the current scene index
    public void LoadLevelComplete()
    {
    SceneManager.LoadScene("Level3");
    }
}
