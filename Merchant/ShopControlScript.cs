using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopControlScript : MonoBehaviour {

	int moneyAmount;
	int isHarpoonSold;
    

	public Text moneyAmountText;
	public Text harpoonPrice;

	public Button buyButton;

    void Start () {
		moneyAmount = PlayerPrefs.GetInt ("MoneyAmount");

    }
	
	void Update () {
		
		moneyAmountText.text = "Money: " + moneyAmount.ToString() + "$";
		isHarpoonSold = PlayerPrefs.GetInt ("IsHarpoonSold");

        buyHarpoon();
	}

	public void buyHarpoon()
	{

        if (ScoreTextScript.moneyAmount >= 5)
        {
            ScoreTextScript.moneyAmount -= 5;
            harpoonPrice.text = "Sold!";
            PlayerPrefs.SetInt("IsHarpoonSold", 1);
            print("moneyamount = " + ScoreTextScript.moneyAmount);
        }
    }

	public void exitShop()
	{
		PlayerPrefs.SetInt ("MoneyAmount", moneyAmount);
    }

	public void resetPlayerPrefs()
	{
		moneyAmount = 0;
		buyButton.gameObject.SetActive (true);
		harpoonPrice.text = "Price: 5$";
		PlayerPrefs.DeleteAll ();
	}
}
