using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievementsPowerUps : MonoBehaviour {

	Slider slider;
	public bool claim;
	public int RewardXP;
	// Use this for initialization
	void Awake () {
		slider = this.gameObject.GetComponent<Slider> ();
		PlayerPrefs.SetInt ("TotalPowerUpsUsed",20);
	}

	// Update is called once per frame
	void Update () {

		if (PlayerPrefs.GetInt("TotalPowerUpsUsed")==4||PlayerPrefs.GetInt("TotalPowerUpsUsed")==20||PlayerPrefs.GetInt("TotalPowerUpsUsed")==50||PlayerPrefs.GetInt("TotalPowerUpsUsed")==100||PlayerPrefs.GetInt("TotalPowerUpsUsed")==500) {
			claim = true;

		}
		if (PlayerPrefs.GetInt("TotalPowerUpsUsed")<4) {
			slider.maxValue = 4;
			RewardXP = 10;

		}

		if (PlayerPrefs.GetInt("TotalPowerUpsUsed")<20&&PlayerPrefs.GetInt("TotalPowerUpsUsed")>=4) {
			slider.maxValue = 20;
			RewardXP = 25;

		}
		if (PlayerPrefs.GetInt("TotalPowerUpsUsed")<50&&PlayerPrefs.GetInt("TotalPowerUpsUsed")>=20) {
			slider.maxValue = 50;
			RewardXP = 75;

		}
		if (PlayerPrefs.GetInt("TotalPowerUpsUsed")<100&&PlayerPrefs.GetInt("TotalPowerUpsUsed")>=50) {
			slider.maxValue = 100;		
			RewardXP = 140;

		}
	
		if (PlayerPrefs.GetInt("TotalPowerUpsUsed")<500&&PlayerPrefs.GetInt("TotalPowerUpsUsed")>=100) {
			slider.maxValue = 500;
			RewardXP = 250;

		}


		slider.transform.Find ("PowerUpsLevelXPText").GetComponent<Text> ().text = PlayerPrefs.GetInt ("TotalPowerUpsUsed") + "/" + slider.maxValue;
		slider.value = PlayerPrefs.GetInt ("TotalPowerUpsUsed");


	}
}

