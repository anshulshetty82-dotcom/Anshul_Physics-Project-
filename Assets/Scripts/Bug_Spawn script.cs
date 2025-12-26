using UnityEngine;

public class RandomScenePopulator : MonoBehaviour
{
    public GameObject[] objectsToSpawn;
    public int numberOfObjects = 50;
    public Vector3 spawnAreaSize = new Vector3(50, 50, 0); // Define the bounds of the spawn area

    void Start()
    {
        PopulateScene();
    }

    void PopulateScene()
    {
        for (int i = 0; i < numberOfObjects; i++)
        {
            // Generate random positions within the defined area
            float randomX = Random.Range(-spawnAreaSize.x / 2, spawnAreaSize.x / 2);
            float randomZ = Random.Range(-spawnAreaSize.z / 2, spawnAreaSize.z / 2);
            // Adjust Y position as needed, e.g., to be slightly above ground
            float randomY = 5f; 

            Vector3 spawnPosition = new Vector3(randomX, randomY, randomZ) + transform.position;

            // Select a random object from the array
            int randomIndex = Random.Range(0, objectsToSpawn.Length); // max is exclusive for int Random.Range
            GameObject prefabToSpawn = objectsToSpawn[randomIndex];

            // Instantiate the object
            Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);
        }
    }
}