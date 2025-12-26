using UnityEngine;

public class MouseFollow : MonoBehaviour
{
    private Camera mainCamera;
    public float distanceFromCamera = 40f; // How far the object stays from the screen

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        Vector3 pos  = Input.mousePosition; 
        pos.z = 50f; 
        transform.position = Camera.main.ScreenToWorldPoint(pos);
  
    }
}