using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTextScript : MonoBehaviour {

    public static int moneyAmount;

    public Text moneyshow;

    // Use this for initialization
    void Awake()
    {
        moneyshow = GetComponent<Text>();

        moneyAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
       moneyshow.text = "Money: " + moneyAmount.ToString();
    }

}
