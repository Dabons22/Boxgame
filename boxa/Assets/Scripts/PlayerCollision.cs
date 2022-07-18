using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    // Start is called before the first frame update
    public GameManager gameManager;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag=="Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().Endgame();
        }
    }
}
