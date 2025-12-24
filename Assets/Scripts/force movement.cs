using UnityEngine;

public class forcemovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public int speed;
    [SerializeField] private int jumpspeed;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.linearVelocity = Vector3.right * speed ;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.linearVelocity = Vector3.left * speed ;
        }
        
        if (Input.GetKey(KeyCode.Space))
        {
            rb.linearVelocity = Vector3.up * jumpspeed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.linearVelocity = Vector3.down * jumpspeed;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.linearVelocity = - Vector3.down * jumpspeed;
        }
        
        
    }
}
