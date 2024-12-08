using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector3 : MonoBehaviour
{
    public void LoadLevel(string levelName)
    {
        SceneManager.LoadScene("Level3");
    }
}
