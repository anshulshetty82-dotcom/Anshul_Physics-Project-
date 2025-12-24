using UnityEngine;

public class Mousecontrol : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float mouseInputspeed; 
    private Rigidbody rb;

    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newp = Input.mousePosition;
        rb.linearVelocity = new Vector3 (0,newp.y,0);

    }
}
