using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievementsRareToys : MonoBehaviour {

	Slider slider;
	public bool claim;
	public int RewardXP;
	// Use this for initialization
	void Awake () {
		slider = this.gameObject.GetComponent<Slider> ();
		PlayerPrefs.SetInt ("TotalRareToysCollected",5);
	}

	// Update is called once per frame
	void Update () {

		if (PlayerPrefs.GetInt("TotalRareToysCollected")==5||PlayerPrefs.GetInt("TotalRareToysCollected")==25||PlayerPrefs.GetInt("TotalRareToysCollected")==100||PlayerPrefs.GetInt("TotalRareToysCollected")==250||PlayerPrefs.GetInt("TotalRareToysCollected")==500) {
			claim = true;

		}
		if (PlayerPrefs.GetInt("TotalRareToysCollected")<5) {
			slider.maxValue = 5;
			RewardXP = 50;
		}

		if (PlayerPrefs.GetInt("TotalRareToysCollected")<25&&PlayerPrefs.GetInt("TotalRareToysCollected")>=5) {
			slider.maxValue = 25;
			RewardXP = 100;

		}

		if (PlayerPrefs.GetInt("TotalRareToysCollected")<100&&PlayerPrefs.GetInt("TotalRareToysCollected")>=25) {
			slider.maxValue = 100;
			RewardXP = 150;

		}
		if (PlayerPrefs.GetInt("TotalRareToysCollected")<250&&PlayerPrefs.GetInt("TotalRareToysCollected")>=100) {
			slider.maxValue = 250;
			RewardXP = 200;

		}
		if (PlayerPrefs.GetInt("TotalRareToysCollected")<500&&PlayerPrefs.GetInt("TotalRareToysCollected")>=250) {
			slider.maxValue = 500;
			RewardXP = 300;

		}

	
		slider.transform.Find ("RareToysLevelXPText").GetComponent<Text> ().text = PlayerPrefs.GetInt ("TotalRareToysCollected") + "/" + slider.maxValue;
		slider.value = PlayerPrefs.GetInt ("TotalRareToysCollected");


	}
}
