using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainSpawner2 : MonoBehaviour
{
    public GameObject terrain;
    public float spawnRate;
    public float heightOffSet;
    private float timer = 0;

    void Start()
    {
        spawnTerrain();
    }

    void Update()
    {   
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnTerrain();
            timer = 0;
        }
    }

    private void spawnTerrain()
    {   
        float lowestPoint = transform.position.y - heightOffSet;
        float highestPoint = transform.position.y + heightOffSet;

        Instantiate(terrain, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
