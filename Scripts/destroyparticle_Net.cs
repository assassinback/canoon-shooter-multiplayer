using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyparticle_Net : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke ("destroy", 1.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void destroy()
	{
		PhotonNetwork.Destroy (gameObject);
	}
}
