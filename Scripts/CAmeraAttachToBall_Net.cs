using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.PostProcessing;
//using UnityEngine.Networking;
public class CAmeraAttachToBall_Net : MonoBehaviour {

	Vector3 offset,startPosition;
	public GameObject cameraMain;
//	public PostProcessingProfile cc;

	float age=0;
	float lifetime=3.0f;
	// Use this for initialization
	void Start () {
//		cameraMain = GameObject.FindGameObjectWithTag("MainCamera");
//		offset = transform.position - cameraMain.transform.position;
//		startPosition= cameraMain.transform.position;
//		StartCoroutine (CameraBack ());
		//Invoke ("CameraBackToPosition", 3.0f);

	}


	// Update is called once per frame
//	[ServerCallback]
	void Update () {
		age += Time.deltaTime;
		if (age>lifetime) {
			PhotonNetwork.Destroy(gameObject);

		}

	}

//	IEnumerator CameraBack()
//	{
//		cameraMain.transform.parent = transform;
//		cc.motionBlur.enabled = true;
//		cameraMain.transform.position = transform.position - offset;
//		yield return new WaitForSeconds (1.0f);
//		GameObject.FindGameObjectWithTag ("Player").GetComponent<ShootToCursor> ().enabled = false;

//		Transform child = cameraMain.transform;
//		child.transform.parent = null;
//		cc.motionBlur.enabled = false;
//		child.transform.position = startPosition;
		//yield return new WaitForSeconds (0.5f);
		//GameObject.FindGameObjectWithTag ("Panel").GetComponent<ShootingWithPanel> ().enabled = true;

		//Invoke ("delay", 0.5f);
//		cameraMain.transform.position = startPosition;
//	}



	void OnCollisionEnter(Collision col)
	{
//		\if (!isServer) {
//			return;
//		}
//		if (col.gameObject.tag=="Target") {
//
//		Transform child = cameraMain.transform;
//		child.transform.parent = null;
//		cameraMain.transform.position = transform.position - (offset);
//		cameraMain.transform.LookAt (col.gameObject.transform);
//		child.transform.position = startPosition;
//

//				}
	}
}
