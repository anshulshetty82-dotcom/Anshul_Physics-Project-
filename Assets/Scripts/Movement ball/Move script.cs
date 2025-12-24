using UnityEngine;

public class Movescript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int speed; 
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
            rb.linearVelocity = Vector3.right * speed;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.linearVelocity = Vector3.left * speed;
        }
    }
}
