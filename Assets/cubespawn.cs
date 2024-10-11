using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class cubespawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    public float spawnInterval = 0.0000000001f; // Time in seconds between spawns
    private float timeSinceLastSpawn = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        timeSinceLastSpawn += Time.deltaTime;

        if (timeSinceLastSpawn >= spawnInterval)
        {
            Instantiate(prefab, transform.position, Quaternion.identity);
            timeSinceLastSpawn = 0f; // Reset the timer after each spawn
        }


    }
   
    
    void Spawner()
    {


    }
}
