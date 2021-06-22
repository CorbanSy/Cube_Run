using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 500f;
    public float sideways = 500f;//put f because it is a float
    // Update is called once per frame
    void FixedUpdate()//made it fixedupdate brcause we are using physics
    {//added a forward force
        rb.AddForce(0, 0, 2000 * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(sideways * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideways * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
    }
}
