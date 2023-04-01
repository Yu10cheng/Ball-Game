
using UnityEngine;

public class GroundTile : MonoBehaviour
{
    GroundSpawner groundSpawner;
    // Start is called before the first frame update
    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
        
    }

    private void OnTriggerExit (Collider Player)
    {
        groundSpawner.SpawnTile();
        Destroy(gameObject, 3);
    }

    
    // Update is called once per frame
    void Update()
    {
        
    } 
}
