using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crossHairRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	float zaxisAngle=0;

	// Update is called once per frame
	void Update () {
		gameObject.transform.eulerAngles = new Vector3 (0, 0, zaxisAngle);
		zaxisAngle += 10;
	}
}
