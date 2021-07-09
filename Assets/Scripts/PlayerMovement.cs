using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb; // create an object for the Rigidbody component

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Update is called once per frame
    void FixedUpdate() // FixedUpdate is good for messing with the Unity physics engine
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); // add a forward force

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameMangager>().EndGame();
        }
    }
}
