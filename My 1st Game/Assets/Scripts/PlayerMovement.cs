using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // this is a reference to the rigidbody component called "rb".
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // we maked this as "fixed"update because we 
    // are using it to mess with physics.
    void FixedUpdate()
    {
        // add a forward force  
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //add a force of 2000 on the z-axis

        if( Input.GetKey("d")) // if the player pressing the "d" key.
        {
            // add a force to the right.
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a")) // if the player pressing the "a" key.
        {
            // add a force to the left.
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
