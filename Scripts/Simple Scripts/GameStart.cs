using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStart : MonoBehaviour {
	bool Once=true;
	public GameObject StartClickScreen;
//	public Text timerText;

	void Awake ()
	{
		Time.timeScale = 0;
		StartClickScreen.gameObject.SetActive (true);
//		timerText.text = "0.000";

			
	}
	// Use this for initialization
	void Start () {
//		TimerScrit.time = 0;

	}


	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)&& Once) {
			Once = false;
			StartClickScreen.gameObject.SetActive (false);
			Time.timeScale = 1;

		}
	}
}
