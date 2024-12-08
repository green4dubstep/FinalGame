using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    // This method loads the Main Menu scene
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu"); // Replace "MainMenu" with the name of your main menu scene
    }
    public void LoadLevel2()
    {
        SceneManager.LoadScene("level2");
    }
}
