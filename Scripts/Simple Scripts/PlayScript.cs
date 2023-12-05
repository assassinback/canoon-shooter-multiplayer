using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PlayScript : MonoBehaviour {

	public GameObject PlayScreenCanvas;
	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt ("Starting",0);

		int GameStarting = PlayerPrefs.GetInt ("Starting");
		if (GameStarting==0) {
			PlayerPrefs.SetInt ("Bomb", 5);
			PlayerPrefs.SetInt ("MultiplyScore", 5);
			PlayerPrefs.SetInt ("FreezeTime", 5);
			PlayerPrefs.SetInt ("AddTime", 5);
			PlayerPrefs.SetInt ("BombUsing", 0);
			PlayerPrefs.SetFloat ("BombX", 50);
			PlayerPrefs.SetFloat ("BombY", 30);
			PlayerPrefs.SetFloat ("BombZ", 5);
			PlayerPrefs.SetInt ("MultiplyScoreUsing", 0);
			PlayerPrefs.SetInt ("MultiplyScoreValue", 100);
			PlayerPrefs.SetFloat("MultiplyScoreTime",10.0f);
			PlayerPrefs.SetInt ("FreezeTimeUsing", 0);
			PlayerPrefs.SetInt ("FreezeTimeMax",15);
			PlayerPrefs.SetInt ("FreezeTimeSpeed",5);
			PlayerPrefs.SetInt ("FreezeTimeNormalMax",5);
			PlayerPrefs.SetInt ("FreezeTimeNormalSpeed",30);
			PlayerPrefs.SetFloat ("FreezeTimeTime", 10.0f);
			PlayerPrefs.SetInt ("AddTimeUsing", 0);
			PlayerPrefs.SetFloat ("AddTimeQuantity", 5f);
			PlayerPrefs.SetInt ("Starting",1);
			PlayerPrefs.SetFloat("Timer1.2",180.0f);
			PlayerPrefs.SetFloat("Timer1.2",90.0f);
			PlayerPrefs.SetInt ("PlayerXP", 0);
			PlayerPrefs.SetInt ("CurrentLevelMax", 0);
			PlayerPrefs.SetInt ("TotalShipsDestroyed", 0);
			PlayerPrefs.SetInt ("TotalPowerUpsUsed", 0);
			PlayerPrefs.SetInt ("TotalNormalToysCollected", 0);
			PlayerPrefs.SetInt ("TotalRareToysCollected", 0);

		}



	}


	// Update is called once per frame
	void Update () {
		
	}

	public void PlayScreen()
	{
		this.gameObject.SetActive (false);
		PlayScreenCanvas.SetActive (true);
	}
	public void ShopScreen()
	{
		SceneManager.LoadScene (13);	
	}
}
