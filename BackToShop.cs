using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToShop : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void ReturnToShop()
	{
		this.gameObject.transform.parent.gameObject.SetActive(false);

	}
}
