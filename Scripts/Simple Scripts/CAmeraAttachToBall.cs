using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;
public class CAmeraAttachToBall : MonoBehaviour {

	Vector3 offset,startPosition;
	public GameObject cameraMain;
	public PostProcessingProfile cc;

	float age=0;
	float lifetime=3.0f;
	// Use this for initialization
	void Start () {
		cameraMain = GameObject.FindGameObjectWithTag("MainCamera");
		offset = transform.position - cameraMain.transform.position;
		startPosition= cameraMain.transform.position;
    	//StartCoroutine (CameraBack ());
//		Invoke ("CameraBack", 1.0f);
		Invoke ("DESTROYING", 3.0f);

	}


	// Update is called once per frame
//	void Update () {
//		age += Time.deltaTime;
//		if (age>lifetime) {
//			Destroy(gameObject);
//
//		}
//
//	}

	IEnumerator CameraBack()
	{
		cameraMain.transform.parent = transform;
		cc.motionBlur.enabled = true;
		cameraMain.transform.position = transform.position - offset;
//		cameraMain.transform.position = new Vector3(0f,0.2f,-3.3f);
	    GameObject.FindGameObjectWithTag ("AttackButton").GetComponent<ShootingWithPanel> ().enabled = false;
		yield return new WaitForSeconds (1.0f);	

//
		Transform child = cameraMain.transform;
		child.transform.parent = null;
		cc.motionBlur.enabled = false;
		child.transform.position = startPosition;
		GameObject.FindGameObjectWithTag ("AttackButton").GetComponent<ShootingWithPanel> ().enabled = true;
//
		cameraMain.transform.position = startPosition;
	}

	void DESTROYING()
	{
		Destroy(gameObject);

	}

	void OnCollisionEnter(Collision col)
	{
		
		//if (col.gameObject.tag=="NormalToys"||col.gameObject.tag=="RareToys"||col.gameObject.tag=="SpaceShips") {

		//Transform child = cameraMain.transform;
		//child.transform.parent = null;
		//cc.motionBlur.enabled = false;
		//child.transform.position = startPosition;
		////		yield return new WaitForSeconds (1.0f);
		//GameObject.FindGameObjectWithTag ("AttackButton").GetComponent<ShootingWithPanel> ().enabled = true;
		////
		//cameraMain.transform.position = startPosition;
		//		}
	}
}
