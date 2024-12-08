using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectorManager : MonoBehaviour
{
    public void LoadSampleScene()
    {
        SceneManager.LoadScene("SamepleScene"); 
    }
    public void LoadLevel2()
    {
        SceneManager.LoadScene("level2");
    }
    public void LoadLevel3()
    {
        SceneManager.LoadScene("level3");
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
