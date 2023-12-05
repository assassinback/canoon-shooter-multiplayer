using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timerForFreezeTime : MonoBehaviour {

	// Use this for initialization
	void Start () {

	
	}



	public void startFreeze()
	{
		if (PlayerPrefs.GetInt ("FreezeTime") > 0) {
			PlayerPrefs.SetInt ("FreezeTimeUsing", 1);
			ScoreManager.freezetime = true;
			PlayerPrefs.SetInt ("FreezeTimeMaxToUse", PlayerPrefs.GetInt ("FreezeTimeMax"));
			PlayerPrefs.SetInt ("FreezeTimeSpeedToUse", PlayerPrefs.GetInt ("FreezeTimeSpeed"));
			Invoke ("stopFreeze", PlayerPrefs.GetFloat ("FreezeTimeTime"));
		}
	}
	void stopFreeze()
	{
		PlayerPrefs.SetInt ("FreezeTimeUsing", 0);
		PlayerPrefs.SetInt ("FreezeTimeMaxToUse", PlayerPrefs.GetInt ("FreezeTimeNormalMax"));
		PlayerPrefs.SetInt("FreezeTimeSpeedToUse",PlayerPrefs.GetInt("FreezeTimeNormalSpeed"));


	}

	// Update is called once per frame
	void Update () {
//		if (PlayerPrefs.GetFloat ("FreezeTimeUsing")==1) {
//			PlayerPrefs.SetFloat ("FreezeTimeUsing",0);
//		}
	}
}
