using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScript : MonoBehaviour
{
    
    public GameObject Player;
    public AudioSource PickUp;

    void start()
    {
        PickUp = GetComponent<AudioSource>();
    }



    void OnTriggerEnter2D(Collider2D col)
    {
        Player = GameObject.FindGameObjectWithTag("Player");

        ScoreTextScript.moneyAmount += 1;
        PickUp.Play();
        Debug.Log("Added Money");
        Destroy(this.gameObject, 0.2f);
        
     }
    }
