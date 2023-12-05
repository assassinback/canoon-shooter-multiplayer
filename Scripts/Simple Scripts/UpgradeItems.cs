using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeItems : MonoBehaviour {
	Text CoinsAvailable;
	public GameObject PopUp;
	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt ("MyScore", 500000);

		CoinsAvailable = GameObject.Find ("TotalCoins").gameObject.transform.Find("Text").GetComponent<Text> ();
		CoinsAvailable.text=getCoinsText();

	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void Upgrade()
	{
		GameObject parentObject = transform.parent.gameObject;

		int price =int.Parse(parentObject.transform.Find("Price").gameObject.transform.Find("Text").GetComponent<Text>().text);
		int Myscore = PlayerPrefs.GetInt ("MyScore");
		if (Myscore >= price) {
			GameObject levelsParent = parentObject.transform.Find ("UpgradeLevel").gameObject;
			for (int i = 0; i < levelsParent.transform.childCount; i++) {
				if (!levelsParent.transform.GetChild (i).gameObject.transform.Find ("Image").gameObject.GetActive ()) {
					levelsParent.transform.GetChild (i).gameObject.transform.Find ("Image").gameObject.SetActive (true);
					Myscore -= price;
					PlayerPrefs.SetInt ("MyScore", Myscore);
					CoinsAvailable.text = getCoinsText ();
					parentObject.transform.Find ("Price").gameObject.transform.Find ("Text").GetComponent<Text> ().text = (price + 2000).ToString ();
					break;
				}
			}
		} else {
			PopUp.SetActive (true);

		
		}
			

		print (transform.parent.name);
	}


	public string getCoinsText()
	{
		string coinsText="0";
		float totalcoins=(float)PlayerPrefs.GetInt ("MyScore");
		if (totalcoins>=10000&&totalcoins<=999999) {
			totalcoins = totalcoins / 1000;
			coinsText = (totalcoins + "K").ToString();
		}
		else if (totalcoins >= 1000000) {
			totalcoins = totalcoins / 1000000;
			coinsText = (totalcoins + "M").ToString ();
		} else {
			coinsText = totalcoins.ToString ();
		}
		return coinsText;
	}

	GameObject findInactiveObjectByName(string childname,string parentName)
	{
		Transform[] objs = Resources.FindObjectsOfTypeAll<Transform>() as Transform[];
		for (int i = 0; i < objs.Length; i++)
			{
			
			if (objs[i].hideFlags==HideFlags.None)
				{
				
				if (objs[i].name==name&& objs[i].transform.parent.transform.parent.name==parentName)
					{
						return objs [i].gameObject;
					}
				}

			}
		return null;

	}
}
