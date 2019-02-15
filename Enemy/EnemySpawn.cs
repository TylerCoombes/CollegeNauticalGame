using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{

    public GameObject[] objects;
    GameObject Enemy;

    public float waitingForNextSpawn = 20;
    public float theCountdown = 20;
    public float xMin;
    public float xMax;
    public float yMin;
    public float yMax;

    // Use this for initialization
    void Start()
    {

        Enemy = objects[Random.Range(0, objects.Length)];

    }

    public void Update()
    {
        theCountdown -= Time.deltaTime;
        if (theCountdown <= 0)
        {
            SpawnObjects();
            theCountdown = waitingForNextSpawn;
        }
    }

    void SpawnObjects()
    {

        Vector2 pos = new Vector2(Random.Range(xMin, xMax), Random.Range(yMin, yMax));
        Instantiate(Enemy, pos, transform.rotation);
    }


}

