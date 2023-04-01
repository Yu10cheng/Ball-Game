using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpwaner1 : MonoBehaviour
{
    public Transform[] obstacleSpawnPoints;
    private bool showObstacleSp1;
    public GameObject smallObstacle;
    public GameObject player;
    private float _distanceToPlayer;
    public float minDistance;
    bool spwanObstacles = true;
    // Start is called before the first frame update
    void Start()
    {
        showObstacleSp1 = true;
        player = GameObject.Find("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (spwanObstacles == true)
        {
            Invoke("SpawnObstacles", 1);
            spwanObstacles = false;
        }
        
    }

    public void SpawnObstacles()
    {
        if (showObstacleSp1 == true)
        {
            int randomIndex = Random.Range(0, obstacleSpawnPoints.Length);

            for (int i = 0; i < obstacleSpawnPoints.Length; i++)
            {
                if (randomIndex == i)
                {
                    _distanceToPlayer = Vector3.Distance(player.transform.position, obstacleSpawnPoints[i].position);
                    if (_distanceToPlayer > minDistance)
                    {
                        Instantiate(smallObstacle, obstacleSpawnPoints[i].position, Quaternion.identity, transform);
                    }
                    
                }
            }
        }


    }
}
