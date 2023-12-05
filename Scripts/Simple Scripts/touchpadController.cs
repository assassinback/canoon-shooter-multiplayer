using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchpadController : MonoBehaviour {


	public FixedJoystick moveJoystick;
	public FixedTouchField TouchField;
	public GameObject cameraMain;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		Movement fps = cameraMain.GetComponent<Movement> ();
		fps.RunAxis =moveJoystick.inputVector;

	}
}
