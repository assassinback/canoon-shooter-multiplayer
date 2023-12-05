using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class TimerScrit : MonoBehaviour {


	public Text timerText;
	public static float time=60f;
	string timername;
	public Button AddTimeButtton;
	public GameObject ScoreText;

	// Use this for initia'lization
	void Start () {
		PlayerPrefs.SetFloat("Timer1.2",30.0f);
		timerText.enabled = false;
		AddTimeButtton.interactable = false;
	}
	
	// Update is called once per frame
	void Update () {

		if (SceneManager.GetActiveScene().buildIndex==3) {
			AddTimeButtton.interactable = true;
			timerText.enabled = true;
			timername = "Timer1.2";
			counter (timername);
			counterUp (timername);
//			timerText.text =Mathf.Round( PlayerPrefs.GetFloat("Timer1.2")).ToString ();

	
		}

		if (SceneManager.GetActiveScene().buildIndex==4) {
			AddTimeButtton.interactable = true;
			timerText.enabled = true;
			timername = "Timer1.3";
			counter (timername);
			counterUp (timername);
			//			timerText.text =Mathf.Round( PlayerPrefs.GetFloat("Timer1.2")).ToString ();


		}

		if(PlayerPrefs.GetInt ("AddTimeUsing")==1) {
			AddTimeInCounter (timername);
		}


	}

	void counter(string timername)
	{
		PlayerPrefs.SetFloat(timername,(PlayerPrefs.GetFloat(timername)-Time.deltaTime));
		char hours= (PlayerPrefs.GetFloat(timername)/60f).ToString ()[0];
		char min1=(PlayerPrefs.GetFloat(timername)%60f).ToString ()[0];
		char min2=(PlayerPrefs.GetFloat(timername)%60f).ToString ()[1];
		timerText.text =hours+":"+min1+min2;
//		timerText.text = (timerText.text [0] + ":" + timerText.text [2] + timerText.text [3]);


	}

	void AddTimeInCounter(string timername)
	{
		PlayerPrefs.SetFloat(timername,(PlayerPrefs.GetFloat(timername)+PlayerPrefs.GetFloat("AddTimeQuantity")));
		PlayerPrefs.SetInt("AddTimeUsing",0);
	}

	void counterUp(string timername)
	{
		if (PlayerPrefs.GetFloat(timername)<=0) {
			ScoreText.GetComponent<ObjectivesAchieved>().GameOverScreen("Your time is up");
		}
	}
}
