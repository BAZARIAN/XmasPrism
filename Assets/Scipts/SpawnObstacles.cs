using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    public GameObject obstacle;
    public GameObject coin;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timeBetweenSpawn;
    private float spawnTime;
    private List<GameObject> list = new List<GameObject>();

    void Start()
    {
        list.Add(obstacle);
        list.Add(coin);
    }
    // Update is called once per frame
    void Update()
    {
        if(Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void Spawn()
    {   
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        GameObject element = list[Random.Range(0, list.Count)];
        Instantiate(element, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}
