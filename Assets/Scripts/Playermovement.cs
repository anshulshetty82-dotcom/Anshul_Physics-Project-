using UnityEngine;

public class Playermovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       // Debug.Log("hi this is unity !! ");

        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Debug.Log("hi i am not unity !!");
        // check which key is pressed 
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //testing if key press is working! 
            Debug.Log("Right arrow key is pressed !");
              transform.position = new Vector3 (transform.position.x+0.2f,transform.position.y,transform.position.z);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
             //testing if key press is working! 
            Debug.Log("left arrow key is pressed!");
             transform.position = new Vector3 (transform.position.x-0.2f,transform.position.y,transform.position.z);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = new Vector3 (transform.position.x,transform.position.y,transform.position.z+0.2f);
        }
           if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = new Vector3 (transform.position.x,transform.position.y,transform.position.z-0.2f);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position = new Vector3 (transform.position.x,transform.position.y+0.5f,transform.position.z);
        } 

        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.localScale = new Vector3 (transform.localScale.x+0.2f,transform.localScale.y+0.2f,transform.localScale.z+0.2f);
        }

          if (Input.GetKey(KeyCode.A))
        {
            transform.localScale = new Vector3 (transform.localScale.x-0.2f,transform.localScale.y-0.2f,transform.localScale.z-0.2f);
        }

        // key input is wokring
        // now i need to move the player 
      
        
    }
}
