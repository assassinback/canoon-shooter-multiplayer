using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShootToCursor : MonoBehaviour{

	public GameObject prefab;
	GameObject cameraMain;
	GameObject parent;


	public float speed=10.0f;
	float distance= 100.0f;
	float Force=1000;
	public float backspeed;
	public bool mouseDown=false;
	bool pulledBack =false;

	Vector3 CameraStartPosition,SphereStartPosition;

	// Use this for initialization
	void Start () {
		parent = transform.parent.gameObject;
		SphereStartPosition = parent.transform.position;
		cameraMain = GameObject.FindGameObjectWithTag ("MainCamera");
		CameraStartPosition = cameraMain.transform.position;
	}

	 //Update is called once per frame
	void Update () {
		
		if (Input.GetMouseButtonDown(0))
		{
			
					mouseDown = true;
//					GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<TweenTransforms> ().enabled = false;
//					gameObject.GetComponentInParent<TweenTransforms> ().enabled=false;
		}
	
		if (mouseDown)
		{
			Force += 100;

			//GetComponent<Rigidbody> ().velocity= Vector3.back * backspeed * Time.deltaTime;
//			if  (GetComponentInParent<TweenTransforms> ().timer>=0.6f) {
//				GetComponentInParent<TweenTransforms> ().paused = true;
//
//				cameraMain.GetComponent<TweenTransforms> ().paused = true;
//
//			}
//			if (!pulledBack) {
//
//				GetComponentInParent<TweenTransforms> ().isPlaying = true;
//			
//				cameraMain.GetComponent<TweenTransforms> ().isPlaying = true;
////				print (gameObject.GetComponentInParent<TweenTransforms> ().);
////				if (gameObject.GetComponentInParent<TweenTransforms> ().percentComplete == 50f) {
////					print("half");
////				}
//				pulledBack = true;
//			}

			//parent.transform.position = Vector3.back * Time.deltaTime;
			//parent.transform.position = Vector3.MoveTowards (transform.position, cameraMain.transform.position, speed *Time.deltaTime );
		}
		if (Input.GetMouseButtonUp(0)) {
			
				
//			GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<TweenTransforms> ().enabled = false;
//			gameObject.GetComponentInParent<TweenTransforms> ().enabled=false;



			Vector3 position = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, distance);
			position = Camera.main.ScreenToWorldPoint (position);
			var go = Instantiate (prefab, transform.position, Quaternion.identity)as GameObject;
			go.transform.LookAt (position);
			Debug.Log (position);
			go.GetComponent<Rigidbody> ().AddForce (go.transform.forward * Force);
//			pulledBack = false;
//			GetComponent<TweenTransforms> ().duration = 0.1f;
//			cameraMain.GetComponent<TweenTransforms> ().duration = 0.1f;
//			GetComponentInParent<TweenTransforms> ().paused=false;
//			cameraMain.GetComponent<TweenTransforms> ().paused=false;
//			GetComponent<TweenTransforms> ().duration = 1f;
//			cameraMain.GetComponent<TweenTransforms> ().duration = 1f;
//			transform.position = SphereStartPosition;
//			cameraMain.transform.position=CameraStartPosition;
			mouseDown = false;
			Force = 1000;


			this.enabled = false;
		}


	
	}

//	private void OnPointerDown(PointerEventData eventData)
//	{
//		if (eventData.pointerPress.gameObject==TouchField.gameObject) {
//			print("its working");
//
//		}
//	}
}
