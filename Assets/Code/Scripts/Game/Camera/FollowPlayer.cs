using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offsetCamera;
    public float cameraY = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPos = player.position + offsetCamera;
        //targetPos.x = 0;  //remain the camera in the middle of the screen
        targetPos.y = cameraY;
        transform.position = targetPos;
    }
}
