using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoyStickCameraControl_Net : MonoBehaviour {

	Transform MainCamera;

	public Joystick joyStick;
	public float SpeedH = 2.0f;
	public float SpeedV = 2.0f;
	public float pow = 0.0f;
	public float pitch = -5.0f;
	public PhotonView pmain;

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
        DontDestroyOnLoad(this.gameObject);
	}

	// Update is called once per frame
	void Update () {
		//		print (joyStick.Horizontal+"horizaontal");
		//		print (joyStick.Vertical+"vertical");
		if (pmain.isMine) {
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
			MainCamera.position = new Vector3 (transform.position.x, transform.position.y + 8, transform.position.z - 30);

			transform.eulerAngles = new Vector3 (Mathf.Clamp( pitch,-30f,30f), Mathf.Clamp( pow,-30f,30f), 0.0f);
			if (pitch>=30f) {
				pitch = 30f;
			}
			if (pitch<=-30f) {
				pitch = -30f;
			}
			if (pow>=30f) {
				pow = 30f;
			}
			if (pow<=-30f) {
				pow = -30f;
			}
			MainCamera.eulerAngles = new Vector3 (Mathf.Clamp( pitch,-30f,30f), pow, 0.0f);
		}
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
