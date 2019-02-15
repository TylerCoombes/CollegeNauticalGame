using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControlScript : MonoBehaviour {

	public Text moneyText;
	public static int moneyAmount;
	int isHarpoonSold;
	public GameObject harpoon;

    public Camera MerchantCamera;
    public Camera MainCamera;

    public GameObject GameCanvas;
    public GameObject CanvasShop;
    public GameObject PauseCanvas;

    // Use this for initialization
    void Start () {
		moneyAmount = PlayerPrefs.GetInt ("MoneyAmount");
		isHarpoonSold = PlayerPrefs.GetInt ("IsHarpoonSold");

		if (isHarpoonSold == 1)
			harpoon.SetActive (true);
		else
			harpoon.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		moneyText.text = "Money: " + moneyAmount.ToString() + "$";

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseCanvas.SetActive(true);
            GameCanvas.SetActive(false);
        }
	}

    public void ShowMerchantCamera()
    {
        MerchantCamera.enabled = true;
        MainCamera.enabled = false;
    }
    public void ShowMainCamera()
    {
        MerchantCamera.enabled = false;
        MainCamera.enabled = true;
    }
    public void disableGameCanvas()
    {
        GameCanvas.SetActive(false);
    }

   public void enableShopCanvas()
    {
        CanvasShop.SetActive(true);
    }
    public void disableShopCanvas()
    {
        CanvasShop.SetActive(false);
    }

    public void enableGameCanvas()
    {
        GameCanvas.SetActive(true);
    }
    public void disablePauseCanvas()
    {
        PauseCanvas.SetActive(false);
    }
}
