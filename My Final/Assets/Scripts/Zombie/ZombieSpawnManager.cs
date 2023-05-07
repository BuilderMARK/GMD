using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawnManager : MonoBehaviour
{
    public GameObject zombiePrefab;
    public float spawnInterval = 3.0f;
    private float timeSinceLastSpawn = 0.0f;
    void Update()
    {
        // Tæl tiden siden sidste spawn
        timeSinceLastSpawn += Time.deltaTime;

        // Check om det er tid til at spawn en zombie
        if (timeSinceLastSpawn >= spawnInterval)
        {
            // Reset tælleren
            timeSinceLastSpawn = 0.0f;

            // Spawn en zombie
            Instantiate(zombiePrefab, transform.position, Quaternion.identity);

            // Log spawn-tidspunktet til konsollen
           // Debug.Log("Zombie spawned at " + Time.time + " seconds.");
        }
    }

}
