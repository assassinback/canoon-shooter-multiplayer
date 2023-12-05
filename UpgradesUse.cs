using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradesUse : MonoBehaviour {

	Text quantity;
	// Use this for initialization
	void Start () {
//		PlayerPrefs.SetInt (transform.name + "Using", 0);

		quantity = transform.Find ("Quantity").GetComponent<Text> ();
		quantity.text = PlayerPrefs.GetInt (transform.name).ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void UpgradesQuantityUsed()
	{
		if (PlayerPrefs.GetInt (transform.name + "Using")==0) {

		    int UpgradeQuantity = PlayerPrefs.GetInt (transform.name);
		    if (UpgradeQuantity>0) {
			PlayerPrefs.SetInt (transform.name + "Using", 1);
			UpgradeQuantity -= 1;
			PlayerPrefs.SetInt (transform.name, UpgradeQuantity);
			quantity.text = PlayerPrefs.GetInt (transform.name).ToString();
			PlayerPrefs.SetInt ("TotalPowerUpsUsed", PlayerPrefs.GetInt("TotalPowerUpsUsed")+1);		

//				if (transform.name=="FreezeTime") {
//					PlayerPrefs.SetInt ("Onceupdate",1);
//				}

			}
		}
	}


		
}
