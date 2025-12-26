using UnityEngine;

public class Targetmovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform target;
    public Transform targetTwo;
    public float speed = 0.5f ; 
    public float speedtwo = 0.5f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if( target != null)
        {
            float Step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position,target.position,speed);
        } else if (targetTwo != null)
        {
             float Step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position,targetTwo.position,speedtwo);
        }
        
    }
}
