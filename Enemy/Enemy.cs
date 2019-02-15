using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float speed;
    public GameObject Player;
    public int health;
    private float dazedTime;
    public float startDazedTime;
    public static int score = 0;
    private Transform target;
    public bool FindPlayer;


    void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }


    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        if (dazedTime <= 0)
        {
            speed = 5;
        }
        else
        {
            speed = 0;
            dazedTime -= Time.deltaTime;
        }

        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        if (target.position.x > transform.position.x)
        {

            transform.localScale = new Vector2(-1, 1);
        }
        else if (target.position.x < transform.position.x)
        {

            transform.localScale = new Vector2(1, 1);
        }
    }

    public void TakeDamage(int damage)
    {
        dazedTime = startDazedTime;
        health -= damage;
        scoreshow.score += 10;
        Debug.Log("damage Taken");
    }
}


