using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoyStickCameraControl : MonoBehaviour {

	 Transform MainCamera;

	public Joystick joyStick;
	public float SpeedH = 2.0f;
	public float SpeedV = 2.0f;
	public float pow = 0.0f;
	public float pitch = -5.0f;
	public GameObject crossHair;

	// Use this for initialization
	void Start () {

//		if (!isLocalPlayer) {
//			Destroy (this);
//			return;
//		}
//
		joyStick = FindObjectOfType<Joystick> ();
		MainCamera = Camera.main.transform;
//		MainCamera = GameObject.Find ("MainCamera").gameObject.transform;
		MainCamera.position = new Vector3 (transform.position.x-1.5f, transform.position.y + 3, transform.position.z - 3);


	}
	
	// Update is called once per frame
	void Update () {
//		print (joyStick.Horizontal+"horizaontal");
//		print (joyStick.Vertical+"vertical");
		pow += SpeedH * joyStick.Horizontal;
		pitch += (SpeedV * joyStick.Vertical)*-1f;

//		Mathf.Clamp (-pitch, -30f, -4.66f);
//		Mathf.Clamp (pow, -40f, 40);
//
//		print(-pitch);
//
//		if (-pitch <= -4.66f && -pitch >= -30f)
//		{
//		
//
//			if (pow >= -40f && pow <= 40f)
//			{
		//crossHair.transform.position = new Vector3 (pow, pitch, crossHair.transform.position.z);
		transform.eulerAngles = new Vector3 (Mathf.Clamp( pitch,-30f,-5f), Mathf.Clamp( pow,-40f,40f), 0.0f);
		if (pitch>=-5F) {
			pitch = -5f;
		}
		if (pitch<=-30f) {
			pitch = -30f;
		}
		if (pow>=30f) {
			pow = 30f;
		}
		if (pow<=-40f) {
			pow = -40f;
		}
		MainCamera.eulerAngles = new Vector3 (Mathf.Clamp( pitch,-30f,30f), pow, 0.0f);
//			}
//
//			else 
//			{
//				print (pow);
//				if (pow < -40f )
//				{
//					pow = -40f;
//				}
//				else if (pow > 40f) 
//				{
//					pow = 40f;
//				}
//			}
//		} 
//
//
//
//		else
//		{
//			if (-pitch > -4.66f)
//			{
//				pitch = 4.66f;
//			}
//			else if (-pitch < -30f) 
//			{
//				pitch = 30f;
//			}
//		}
	}
}
