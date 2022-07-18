using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    bool GameHasEnded = false;
    public GameObject gameObjectUI;
    public float GameDelay = 2f;
    public void CompleteLevel() {
        gameObjectUI.SetActive(true);
    }
    public void Endgame() {
        if (GameHasEnded == false)
        {
            GameHasEnded = true;
            Invoke("Restart",GameDelay);
        }
    }
     void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
