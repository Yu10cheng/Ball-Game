
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public Transform player;
    [SerializeField] private GameManager _gameManager;

    
    private void OnCollisionEnter(Collision collisionInfo)
    {
        
        if (collisionInfo.collider.tag == "Obstacle")
        {
            GetComponent<PlayerMovement>().enabled = false;
            _gameManager.EndGame();

        }
    }

    private void Update()
    {
        if (player.position.y< -1)
        {
            _gameManager.EndGame();
        }
    }
}
