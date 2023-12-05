using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeForMultiply : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void StartMultiply()
	{
		if (PlayerPrefs.GetInt ("MultiplyScore")>0)
		{

		PlayerPrefs.SetInt ("MultiplyScoreUsing", 1);
			ScoreManager.multiplytime = true;
		Invoke("stopMultiply",PlayerPrefs.GetFloat("MultiplyScoreTime"));

		}
	}


	void stopMultiply(){

		PlayerPrefs.SetInt ("MultiplyScoreUsing", 0);

	}
}
