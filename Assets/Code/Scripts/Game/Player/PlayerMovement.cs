using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // reference to the Rigidbody component called "Rb"
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // We marked this as "Fixed" Update becasue we
    //are using it to mess with physics.
    void FixedUpdate()
    {
        //add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetAxis("Mouse X")<0)
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetAxis("Mouse X")>0)
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
