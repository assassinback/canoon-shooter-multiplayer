using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpaceShipsButtonActivate : MonoBehaviour {

	Slider slider;
	public string url = "http://teamstrixplasma-com.stackstaging.com/Multi/UserInfo/AddLevelAndExp.php";

	// Use this for initialization
	void Start () {
		slider = this.gameObject.transform.parent.GetComponent<Slider> ();
	}

	// Update is called once per frame
	void Update () {
		if (slider.GetComponent<AchievementsSpaceShips>().claim==true) {
			this.gameObject.GetComponent<Button> ().interactable = true;
		} 
		else {
			this.gameObject.GetComponent<Button> ().interactable = false;

		}
	}
	public void ClaimReward()
	{
		slider.GetComponent<AchievementsSpaceShips> ().claim = false;
		PlayerPrefs.SetInt ("PlayerXP",PlayerPrefs.GetInt ("PlayerXP")+slider.GetComponent<AchievementsSpaceShips>().RewardXP);
		StartCoroutine (PlayerXpDBSave ());
		PlayerPrefs.SetInt ("TotalShipsDestroyed", PlayerPrefs.GetInt ("TotalShipsDestroyed") + 1);
		print (PlayerPrefs.GetInt ("PlayerXP").ToString());
	}

	public IEnumerator PlayerXpDBSave()
	{
		WWWForm ch1 = new WWWForm();
		ch1.AddField("username", PlayerPrefs.GetString("username"));
		ch1.AddField("CurrentEXP", PlayerPrefs.GetInt("PlayerXP"));
		ch1.AddField("expneeded", PlayerPrefs.GetInt("CurrentLevelMax"));
		WWW wWW = new WWW(url, ch1);
		yield return wWW;
	}
}

