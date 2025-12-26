using System.Runtime.CompilerServices;
using UnityEngine;

public class SpringToggle : MonoBehaviour
{
    private SpringJoint spring;
    public float originalStrength = 100f; // Set this to your desired pull power

    void Start()
    {
        spring = GetComponent<SpringJoint>();
        // Ensure the spring starts with the original strength
        spring.spring = originalStrength;
    }

    void Update()
    {
        // 1. While holding the mouse: The spring becomes "limp"
        if (Input.GetMouseButton(0)) 
        {
            spring.spring = 0f;
        }
       
  
    }
    private void OnCollisionEnter(Collision collision)
    {
        spring.spring = originalStrength;
    }
}



