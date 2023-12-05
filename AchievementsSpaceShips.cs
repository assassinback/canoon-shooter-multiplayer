using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievementsSpaceShips : MonoBehaviour {

	Slider slider;
	public bool claim;
	public int RewardXP;


	// Use this for initialization
	void Awake () {
		slider = this.gameObject.GetComponent<Slider> ();
		PlayerPrefs.SetInt ("TotalShipsDestroyed",300);
	}

	// Update is called once per frame
	void Update () {

		if (PlayerPrefs.GetInt("TotalShipsDestroyed")==100||PlayerPrefs.GetInt("TotalShipsDestroyed")==200||PlayerPrefs.GetInt("TotalShipsDestroyed")==300||PlayerPrefs.GetInt("TotalShipsDestroyed")==400||PlayerPrefs.GetInt("TotalShipsDestroyed")==1000||PlayerPrefs.GetInt("TotalShipsDestroyed")==3000) {
			claim = true;

		}
		if (PlayerPrefs.GetInt("TotalShipsDestroyed")<100) {
			slider.maxValue = 100;
			RewardXP = 50;	
		}

		if (PlayerPrefs.GetInt("TotalShipsDestroyed")<200&&PlayerPrefs.GetInt("TotalShipsDestroyed")>=100) {
			slider.maxValue = 200;
			RewardXP = 150;
		}
		if (PlayerPrefs.GetInt("TotalShipsDestroyed")<300&&PlayerPrefs.GetInt("TotalShipsDestroyed")>=200) {
			slider.maxValue = 300;
			RewardXP = 500;
			print("araha hai");
		}
		if (PlayerPrefs.GetInt("TotalShipsDestroyed")<400&&PlayerPrefs.GetInt("TotalShipsDestroyed")>=300) {
			slider.maxValue = 400;
			RewardXP = 1000;
		}

		if (PlayerPrefs.GetInt("TotalShipsDestroyed")<1000&&PlayerPrefs.GetInt("TotalShipsDestroyed")>=400) {
			slider.maxValue = 1000;
			RewardXP = 1500;
		}

		if (PlayerPrefs.GetInt("TotalShipsDestroyed")<3000&&PlayerPrefs.GetInt("TotalShipsDestroyed")>=1000) {
			slider.maxValue = 3000;
			RewardXP = 1800;
		}

		slider.transform.Find ("SpaceShipsLevelXPText").GetComponent<Text> ().text = PlayerPrefs.GetInt ("TotalShipsDestroyed") + "/" + slider.maxValue;
		slider.value = PlayerPrefs.GetInt ("TotalShipsDestroyed");


	}



}


