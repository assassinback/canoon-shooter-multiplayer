
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievementsNormalToys : MonoBehaviour {

	Slider slider;
	public bool claim;
	public int RewardXP;
	// Use this for initialization
	void Awake () {
		slider = this.gameObject.GetComponent<Slider> ();
		PlayerPrefs.SetInt ("TotalNormalToysCollected",1000);
	}
	
	// Update is called once per frame
	void Update () {

		if (PlayerPrefs.GetInt("TotalNormalToysCollected")==100||PlayerPrefs.GetInt("TotalNormalToysCollected")==250||PlayerPrefs.GetInt("TotalNormalToysCollected")==500||PlayerPrefs.GetInt("TotalNormalToysCollected")==1000||PlayerPrefs.GetInt("TotalNormalToysCollected")==2000||PlayerPrefs.GetInt("TotalNormalToysCollected")==3000||PlayerPrefs.GetInt("TotalNormalToysCollected")==4000||PlayerPrefs.GetInt("TotalNormalToysCollected")==5000) {
			claim = true;
		
		}
		if (PlayerPrefs.GetInt("TotalNormalToysCollected")<100) {
			slider.maxValue = 100;
			RewardXP = 25;
		}

		if (PlayerPrefs.GetInt("TotalNormalToysCollected")<250&&PlayerPrefs.GetInt("TotalNormalToysCollected")>=100) {
			slider.maxValue = 250;
			RewardXP = 25;

		}

		if (PlayerPrefs.GetInt("TotalNormalToysCollected")<500&&PlayerPrefs.GetInt("TotalNormalToysCollected")>=250) {
			slider.maxValue = 500;
			RewardXP = 50;

		}
		if (PlayerPrefs.GetInt("TotalNormalToysCollected")<1000&&PlayerPrefs.GetInt("TotalNormalToysCollected")>=500) {
			slider.maxValue = 1000;
			RewardXP = 100;

		}
		if (PlayerPrefs.GetInt("TotalNormalToysCollected")<2000&&PlayerPrefs.GetInt("TotalNormalToysCollected")>=1000) {
			slider.maxValue = 2000;
			RewardXP = 200;

		}
		if (PlayerPrefs.GetInt("TotalNormalToysCollected")<3000&&PlayerPrefs.GetInt("TotalNormalToysCollected")>=2000) {
			slider.maxValue = 3000;
			RewardXP = 300;

		}
		if (PlayerPrefs.GetInt("TotalNormalToysCollected")<4000&&PlayerPrefs.GetInt("TotalNormalToysCollected")>=3000) {
			slider.maxValue = 4000;
			RewardXP = 400;

		}
		if (PlayerPrefs.GetInt("TotalNormalToysCollected")<5000&&PlayerPrefs.GetInt("TotalNormalToysCollected")>=4000) {
			slider.maxValue = 5000;
			RewardXP = 500;

		}

		slider.transform.Find ("ToysLevelXPText").GetComponent<Text> ().text = PlayerPrefs.GetInt ("TotalNormalToysCollected") + "/" + slider.maxValue;
		slider.value = PlayerPrefs.GetInt ("TotalNormalToysCollected");


	}
}
