using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector2 : MonoBehaviour
{
    public void LoadLevel(string levelName)
    {
        SceneManager.LoadScene("Level2");
    }
}
