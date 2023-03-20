using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // reference to the Rigidbody component called "rb"
    public Rigidbody rb;
    public float forwardSpeed = 2000f;
    //public float sidewaysSpeed = 500f;
    //public float speed = 10.0f;
    //private Vector3 mousePosition;
    public float forceMultiplier = 100.0f;
    public float maxSpeed = 50.0f;
    public float tilt = 5.0f;
    public float smoothing = 0.5f;
    public float xSpeedFactor = 2.0f;
    public float sensitivity = 20.0f;
    private float targetX;
    //private float currentVelocity = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // We marked this as "Fixed" Update becasue we
    //are using it to mess with physics.
    void FixedUpdate()
    {
        float mouseX = Input.mousePosition.x;
        
        targetX = Mathf.Lerp(targetX, (mouseX / Screen.width) * sensitivity - (sensitivity / 2), smoothing);

        float xVelocity = targetX * xSpeedFactor * forceMultiplier;
        rb.AddForce(xVelocity, 0.0f, forwardSpeed * Time.deltaTime);

        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }

        float rotationAngle = -targetX * tilt;
        Quaternion targetRotation = Quaternion.Euler(0.0f, 0.0f, rotationAngle);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, smoothing);

        /*#1
        // Add forward movement using addforce
        rb.AddForce(0, 0, forwardSpeed * Time.deltaTime);
        float mouseX = Input.mousePosition.x;
        targetX = Mathf.Lerp(targetX, (mouseX / Screen.width) * sensitivity - (sensitivity / 2), smoothing);

        Vector3 newPosition = transform.position;
        //newPosition.z += Time.deltaTime * speed;
        newPosition.x = targetX;
        
        transform.position= newPosition;

        float rotationAngle = -targetX * tilt;
        Quaternion targetRotation = Quaternion.Euler(0.0f, 0.0f, rotationAngle);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, smoothing);
        */
        //add a forward force



        /* 
         if (Input.GetKey("d"))
         {
             rb.AddForce(sidewaysSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
         }
         if (Input.GetKey("a"))
         {
             rb.AddForce(-sidewaysSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
         }
         if (rb.position.y < -1f)
         {
             FindObjectOfType<GameManager>().EndGame();
         }
         */


    }

}
