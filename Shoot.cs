using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnMouseUp()
	{
		
		Debug.Log ("clicked");

		this.gameObject.SetActive (false);

	}



}
