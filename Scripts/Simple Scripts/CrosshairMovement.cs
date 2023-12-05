using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrosshairMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float x = Screen.width / 2;
		float y = Screen.height / 2;

		transform.position = new Vector3 (x, y, transform.position.z);
	}
}
