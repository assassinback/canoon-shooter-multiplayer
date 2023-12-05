using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillExperience : MonoBehaviour {


	public GameObject SliderObject;
	float time;
	float maxTime=20.0f;
	Slider slider;
	// Use this for initialization
	void Start () {
		slider = SliderObject.GetComponent<Slider>();
		PlayerPrefs.SetInt("CurrentLevelMax",5000) ;
		PlayerPrefs.SetInt ("PlayerXP", 1000);

		slider.maxValue =PlayerPrefs.GetInt("CurrentLevelMax") ;
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetInt("PlayerXP")<PlayerPrefs.GetInt("CurrentLevelMax")) {
			slider.value = PlayerPrefs.GetInt("PlayerXP");
			slider.transform.Find ("Text").GetComponent<Text> ().text = PlayerPrefs.GetInt ("PlayerXP").ToString ()+"/"+PlayerPrefs.GetInt("CurrentLevelMax").ToString();
		}
		if (PlayerPrefs.GetInt("PlayerXP")==PlayerPrefs.GetInt("CurrentLevelMax")) {

			//get other levels max limit from database here in currentlevelmax playerprefs

			slider.maxValue = PlayerPrefs.GetInt("CurrentLevelMax");
			//panel and animation for level up to apply here


		}
	}
}
