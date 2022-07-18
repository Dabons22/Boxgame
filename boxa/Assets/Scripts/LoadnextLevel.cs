using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadnextLevel : MonoBehaviour
{
    public void LoadNextLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+ 1);
    }
}
