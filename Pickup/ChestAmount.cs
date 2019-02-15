using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestAmount : MonoBehaviour {

    GameObject Player;
    public AudioSource Collect;

    void Start()
    {
        Collect = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Player = GameObject.FindGameObjectWithTag("Player");

        ScoreTextScript.moneyAmount += 3;
        Collect.Play();
        Destroy(this.gameObject, 0.2f);

        if (gameObject.name == "Player")
        {
            ScoreTextScript.moneyAmount += 3;
            Destroy(gameObject);
        }
    }
}

