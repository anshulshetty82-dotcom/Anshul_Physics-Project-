using UnityEngine;

public class ArcingArm : MonoBehaviour
{
    public float pullStrength = 150f; 
    public float maxSpeed = 50f;
    private Rigidbody rb;
    private Camera mainCam;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        mainCam = Camera.main;
        
        // Increase solver iterations for a "stronger" arm that doesn't stretch
        Physics.defaultSolverIterations = 20; 
    }

    void FixedUpdate()
    {
        // 1. Get Mouse Position in Pixels
        Vector3 mousePixelPos = Input.mousePosition;

        // 2. Set the distance from the camera (Z-axis) 
        // This should be the distance between your Camera and your Game Object
        mousePixelPos.z = Mathf.Abs(mainCam.transform.position.z - transform.position.z);

        // 3. Convert Pixels to World Units (No more 108 or 246!)
        Vector3 targetPos = mainCam.ScreenToWorldPoint(mousePixelPos);

        // 4. Calculate the Pull
        Vector3 forceDirection = targetPos - transform.position;

        // 5. Apply Force
        rb.AddForce(forceDirection * pullStrength, ForceMode.Acceleration);

        // 6. Speed Limit
        if (rb.linearVelocity.magnitude > maxSpeed)
        {
            rb.linearVelocity = rb.linearVelocity.normalized * maxSpeed;
        }
    }
}