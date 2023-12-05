using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopButtonScript : MonoBehaviour {

	public GameObject AssetButton1,AssetDetailsButton1;
	// Use this for initialization
	void Start () {
//		AssetDetailsButton1.SetActive (false);
//		AssetButton1.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ShowDetails()
	{
		AssetDetailsButton1.SetActive (true);
		AssetButton1.SetActive (false);
	}
	public void HideDetails()
	{
		AssetDetailsButton1.SetActive (false);
		AssetButton1.SetActive (true);
	}
}
