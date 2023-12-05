using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCoins : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke ("destroying", 2f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void destroying()
	{
		Destroy (this.gameObject);
	}

}
