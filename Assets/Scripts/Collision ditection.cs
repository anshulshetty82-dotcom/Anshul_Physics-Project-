using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using TMPro.EditorUtilities;
using UnityEditor.Callbacks;
using UnityEngine.SceneManagement;


public class Collisionditection : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private int NumberOfBounces;
    public GameObject gamedata;
    public GameObject rb2; 
   
    private Rigidbody ballphysics;
    //private Rigidbody newrb;

    void Start()
    {
        //initialize the variable (in this case the program knows its zero, dont have to do this for every variable.)
        NumberOfBounces = 0;
        ballphysics = GetComponent<Rigidbody>();
        ballphysics.linearVelocity=new Vector3(Random.Range(-10,10), Random.Range(-10,10),0);
        //newrb = rb2.GetComponent<Rigidbody>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        NumberOfBounces++;
        Debug.Log("the number of bounces"+ NumberOfBounces);
        gamedata.GetComponent<TMP_Text>().text = "Bounces: " + NumberOfBounces;

        if (collision.gameObject.CompareTag("btmwall"))
        {
            Destroy(gameObject);
            restartlevel();
        }
        
    }

    void restartlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    

}
