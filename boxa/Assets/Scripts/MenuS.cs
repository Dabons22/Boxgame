using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuS : MonoBehaviour
{
    public void Startgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+ 1);
    }
}
