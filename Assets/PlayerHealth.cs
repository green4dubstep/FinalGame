using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public void KillPlayer()
    {
        Debug.Log("Player Died!");
        // You can add additional game over logic here, such as:
        // - Reloading the scene
        // - Showing a game over screen
        FindObjectOfType<GameManager>().GameOver();
    }
}
