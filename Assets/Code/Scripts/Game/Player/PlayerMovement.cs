using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // reference to the Rigidbody component called "Rb"
    public Rigidbody rb;
    public float forwardSpeed = 2000f;
    public float sidewaysSpeed = 500f;
    private Vector3 mousePosition;
    //public float xInput;
    //public float yInput;
    // Start is called before the first frame update
    void Start()
    {

    }

    // We marked this as "Fixed" Update becasue we
    //are using it to mess with physics.
    void FixedUpdate()
    {
        //add a forward force
        rb.AddForce(0, 0, forwardSpeed * Time.deltaTime);



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

    }
    /*private void ProcessInputs()
    {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");
    }
    */
}
