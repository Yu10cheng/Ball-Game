
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public Transform player;
    [SerializeField] private GameManager _gameManager;
    
    [SerializeField] BoolSO ifUsedUpgrade;

    private void Start()
    {
        

    }
    private void OnCollisionEnter(Collision collisionInfo)
    {

        if (collisionInfo.collider.tag == "Obstacle")
        {
            GetComponent<PlayerMovement>().enabled = false;
            _gameManager.EndGame();
            //button.UpgradeExpired();
            ifUsedUpgrade.value = false;
        }
    }

    private void Update()
    {
        if (player.position.y < -1)
        {
            _gameManager.EndGame();
            ifUsedUpgrade.value = false;
            //button.UpgradeExpired();
        }
    }


}
