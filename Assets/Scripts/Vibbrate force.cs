using UnityEngine;

public class BugVibration : MonoBehaviour
{
    public float buzzSpeed = 10f;    // How fast the bug vibrates
    public float buzzAmount = 0.5f;   // How far it moves from the center
    
    private Vector3 startPosition;
    private float seedX;
    private float seedY;

    void Start()
    {
        // Remember where the sphere started
        startPosition = transform.position;

        // Give each sphere a unique random start so they don't move in sync
        seedX = Random.value * 100f;
        seedY = Random.value * 100f;
    }

    void Update()
    {
        // 1. Calculate a smooth random offset using Perlin Noise
        float moveX = Mathf.PerlinNoise(Time.time * buzzSpeed, seedX) - 0.5f;
        float moveY = Mathf.PerlinNoise(seedY, Time.time * buzzSpeed) - 0.5f;

        // 2. Combine the offset with the start position
        Vector3 offset = new Vector3(moveX, moveY, 0) * buzzAmount;
        
        // 3. Apply the movement
        transform.position = startPosition + offset;
    }
}