
using UnityEngine;

public class Cameramovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject targetlock; 
    private float newvelocity; 

    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        newvelocity = targetlock.transform.position.x ;
        transform.position = new Vector3 (newvelocity, transform.position.y, transform.position.z);
    }
}
