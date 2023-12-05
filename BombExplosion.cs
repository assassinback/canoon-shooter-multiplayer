using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombExplosion : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	 void OnTriggerEnter(Collider col)
	{
		col.gameObject.GetComponent<BlastFruits> ().destroyBox (this.gameObject);

	}

	void OnTriggerExit()
	{
		Destroy (this.gameObject);

	}
}
