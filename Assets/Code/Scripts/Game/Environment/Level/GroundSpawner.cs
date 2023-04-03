
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject groundTile;
    private Vector3 _nextSpawn;


    public void SpawnTile()
    {
        GameObject temp = Instantiate(groundTile, _nextSpawn, Quaternion.identity);
        _nextSpawn = temp.transform.GetChild(1).transform.position;
    }
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            SpawnTile(); 
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
