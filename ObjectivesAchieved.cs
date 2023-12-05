using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ObjectivesAchieved : MonoBehaviour {
	public GameObject LevelEndPanel;
	public GameObject Crosshair;
	public GameObject ScoreCanvas;
	public GameObject winprefab;
	public GameObject GameOverPanel;

	public Text Score;
	// Use this for initialization
	void Awake () {
		Crosshair.SetActive (true);
		ScoreCanvas.SetActive (true);
		LevelEndPanel.SetActive (false);
		GameOverPanel.SetActive (false);

		ScoreManager.Score = 0;
	}
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		Score.text = ScoreManager.Score.ToString();


		if (SceneManager.GetActiveScene().buildIndex==2) {
			if (ScoreManager.Score==10) {
//				Instantiate (winprefab);
				ScoreManager.addtime=false;
				ScoreManager.multiplytime=false;
				ScoreManager.bomb=false;
				ScoreManager.freezetime=false;
				StartCoroutine( Screens (2f));		
			}
		} 
		else if (SceneManager.GetActiveScene().buildIndex==3)
		{
			if (ScoreManager.bomb==true&& ScoreManager.multiplytime==true&&ScoreManager.freezetime==true) {
//				Instantiate (winprefab);
				StartCoroutine( Screens (2f));

			}
		}

		else if (SceneManager.GetActiveScene().buildIndex==4)
		{
			if (ScoreManager.Score==15) {
				//				Instantiate (winprefab);
				StartCoroutine( Screens (2f));

			}
		}

	

	}

	IEnumerator Screens(float delay)
	{
		Time.timeScale = 0;
		yield return new WaitForSeconds(delay);
		TimerScrit.time = 0;
		Crosshair.SetActive (false);
		ScoreCanvas.SetActive (false);
		LevelEndPanel.SetActive (true);
	}


	public void GameOverScreen(string msg)
	{
		Time.timeScale = 0;
		Crosshair.SetActive (false);
		ScoreCanvas.SetActive (false);
		GameOverPanel.SetActive (true);
		GameOverPanel.transform.Find ("GameOverText").gameObject.GetComponent<Text> ().text = msg;
	}

}
