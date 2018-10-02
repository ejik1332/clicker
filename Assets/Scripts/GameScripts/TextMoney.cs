using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextMoney : MonoBehaviour {
	static Text moneyText;
	static long money;
	// Use this for initialization
	void Start () {
		moneyText = GameObject.Find("Money").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		moneyText.text = "$ " + money;
	}

	public static void AdjustCurrentValue(long moneyl)
	{
		money += moneyl;
	}

	public static long currentMoney
	{
		get{ return money; }
	}
}
