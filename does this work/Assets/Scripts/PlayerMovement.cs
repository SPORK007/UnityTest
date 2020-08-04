using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 500f;
    public float sidewaysForce = 500f;
    public float jumpForce = 300f;
    public bool cubeOnGround = true;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("oh god");
    }

    // Update is called once per frame
    void FixedUpdate()
    {    
        
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -forwardForce * Time.deltaTime);
        }
        if (Input.GetButtonDown("Jump") && cubeOnGround)
        {
            rb.AddForce(0, jumpForce * Time.deltaTime, 0, ForceMode.Impulse);
            cubeOnGround = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if(collision.gameObject.tag == "jumpable")
        { 
            cubeOnGround = true;

        }
    }
}
