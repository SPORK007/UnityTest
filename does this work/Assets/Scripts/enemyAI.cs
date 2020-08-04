using UnityEngine;

public class enemyAI : MonoBehaviour
{
    public Rigidbody rb;
    public float enemyForce = 100f;
    public bool life;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (life == true)
        {
            rb.AddForce(0, 0, enemyForce * Time.deltaTime);
        }

    }
}
