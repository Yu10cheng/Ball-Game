using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner1 : MonoBehaviour
{
    public Transform[] obstacleSpawnPoints;
    private bool showObstacleSp1;
    public GameObject smallObstacle;
    bool spwanObstacles = true;

    public GameObject player;
    public float minDistance;
    private float _distanceToPlayer;
    bool calculateDis = true;

    void Start()
    {
        showObstacleSp1 = true;
        player = GameObject.FindGameObjectWithTag("Player");
        Invoke("SpawnObstacles", 1);
    }


    void Update()
    {
        

    }

    public void SpawnObstacles()
    {
        if (showObstacleSp1 == true)
        {
            int randomIndex = Random.Range(0, obstacleSpawnPoints.Length);
            if (calculateDis == true)
            {
                calculateDis = false;
                _distanceToPlayer = Vector3.Distance(player.transform.position, obstacleSpawnPoints[randomIndex].position);
                if (_distanceToPlayer > minDistance)
                {
					
					 Instantiate(smallObstacle, obstacleSpawnPoints[randomIndex].position, Quaternion.identity, transform);
                    /*for (int i = 0; i < obstacleSpawnPoints.Length; i++)
                    {
                        if (randomIndex == i)
                        {
                           
                            
                        }
                    }*/
                }
            }
            

            //int randomIndex = Random.Range(0, obstacleSpawnPoints.Length);
			//Instantiate(smallObstacle, obstacleSpawnPoints[randomIndex].position, Quaternion.identity, transform);
            
			/*for (int i = 0; i < obstacleSpawnPoints.Length; i++)
            {

                if (randomIndex == i)
                {
                    
                }
            }
			*/


        }


    }
}
