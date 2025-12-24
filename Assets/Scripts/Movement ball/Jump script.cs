using UnityEngine;

public class Jumpscript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int jumpForce; 
    private Rigidbody rb; 
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.linearVelocity = Vector3.up *  jumpForce;
        }
        
    }
}
