using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public static int playerHealth = 100;
    private int SharkDmg = 10;
    public static int moneyAmountHealth;
    public static Text moneyAmountText;
    public Text BottlePrice;

    public Button buyButton;
    Text text;


    void Start()
    {
        print(playerHealth);
    }

    void Awake()
    {
        text = GetComponent<Text>();


    }

    void Update()
        {
        text.text = "Health: " + playerHealth;

        moneyAmountText.text = "Money: " + moneyAmountHealth + "$";

        Buyhealth();
        FiftyHealth();
        SixtyHealth();
        }


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            playerHealth -= SharkDmg;

            print("Hearts: " + playerHealth);
        }
        if (playerHealth <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Death");
        }
    }

    public void Buyhealth()
    {
        
            if (ScoreTextScript.moneyAmount >= 5)
        { 
            ScoreTextScript.moneyAmount -= 5;
            BottlePrice.text = "Sold!";
            playerHealth = playerHealth + 30;
            print("moneyamount = " + ScoreTextScript.moneyAmount);
        }
    }

    public void FiftyHealth()
    {

        if (ScoreTextScript.moneyAmount >= 10)
        {
            ScoreTextScript.moneyAmount -= 10;
            BottlePrice.text = "Sold!";
            playerHealth = playerHealth + 50;
            print("moneyamount = " + ScoreTextScript.moneyAmount);
        }
    }

    public void SixtyHealth()
    {

        if (ScoreTextScript.moneyAmount >= 15)
        {
            ScoreTextScript.moneyAmount -= 15;
            BottlePrice.text = "Sold!";
            playerHealth = playerHealth + 65;
            print("moneyamount = " + ScoreTextScript.moneyAmount);
        }
    }
}
