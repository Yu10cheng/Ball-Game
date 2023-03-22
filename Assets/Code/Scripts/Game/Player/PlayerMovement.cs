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
    public float jumpForce = 2000f;
    private bool isGrounded;
    public Vector3 playerGravity;

	float distToGround;

    //private float currentVelocity = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        isGrounded = true;
        playerGravity = Physics.gravity;
		
		 distToGround =  GetComponent<Collider>().bounds.extents.y;// half the height of the game object

    }
	
	void Update()
	{
		
		 if (Input.GetMouseButtonDown(0) && isGrounded)
        {
            rb.AddForce(0.0f, jumpForce, 0, ForceMode.VelocityChange);
            isGrounded = false;
        }
	}
	

    // We marked this as "Fixed" Update becasue we
    //are using it to mess with physics.



    void FixedUpdate()
    {
        //This line gets the x-coordinate of the mouse position in pixels from the left edge of the screen.
        //just a float number
        float mouseX = Input.mousePosition.x;
        //Simplified: float targetX = (mouseX / Screen.width) * 20 - 10;
        //Mathf.Lerp t=0.5 means returns the middle position between old position targetX and new targetX position.
        targetX = Mathf.Lerp(targetX, (mouseX / Screen.width) * sensitivity - (sensitivity / 2), smoothing);
        // give this number some factors to adjust its speed in Unity inspector
        float xVelocity = targetX * xSpeedFactor * forceMultiplier;
        //make target move by adding this speed as force using rigidbody
        rb.AddForce(xVelocity, 0.0f, 0.0f);
        rb.AddForce(0.0f, 0.0f, forwardSpeed * Time.fixedDeltaTime, ForceMode.VelocityChange);
        // give the maxSpeed limit
        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }
        // calculate the targetRotation angle of rotate
        float rotationAngle = -targetX * tilt;
        // apply rotation angle to the object z Axis of the object as rotate angle
        Quaternion targetRotation = Quaternion.Euler(0.0f, 0.0f, rotationAngle);
        // make the object continously rotate based on the new mouse position
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, smoothing);
        //make player jump










        /*#1 simple move but not feeling good when playing the game.
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



        /* Brackeys tutorial 
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
	
	/* bool IsGrounded()  
	 {
		 Debug.DrawRay(transform.position, -Vector3.up * distToGround + 0.1f,  Color.green );
		 return Physics.Raycast(transform.position, -Vector3.up, distToGround + 0.1f);
	 }*/
 
    void OnCollisionEnter(Collision collisionGround)
    {
		
        if (collisionGround.collider.tag == ("Ground"))
        {
            isGrounded = true;
        }
    }

}
