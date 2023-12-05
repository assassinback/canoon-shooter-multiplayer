using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {

	GameObject prefab;
	public GameObject simpleBall;
	public GameObject bomb; 
	float distance= 100.0f;
	public GameObject child;
	// Use this for initialization
	void Start () {

//		child = transform.Find ("Shooter").gameObject;

//		PlayerPrefs.SetInt ("BombUsing", 1);
//		PlayerPrefs.SetInt ("MultiplyScoreUsing", 1);


	}
	bool mouseDown;
	//	float force = 1000;
	// Update is called once per frame

	void Update () {

//		if (PlayerPrefs.GetInt ("FreezeTimeUsing") == 1) {
//
//			if (ScoreManager.TotalFreezeTime <= PlayerPrefs.GetFloat ("FreezeTimeTime")) {
//				ScoreManager.TotalFreezeTime += Time.deltaTime;
//			} 
//			else 
//			{
////				if (PlayerPrefs.GetInt ("FreezeTimeUsing") == 1) {
//
//					PlayerPrefs.SetInt ("FreezeTimeUsing", 0);
////				}
//			}
//
//
//		}
	}

	public void AttackShoot(float force)
	{
		if (PlayerPrefs.GetInt("BombUsing")==1) 
		{
			bomb.GetComponent<BoxCollider> ().size =new Vector3 (PlayerPrefs.GetFloat("BombX"),PlayerPrefs.GetFloat("BombY"),PlayerPrefs.GetFloat("BombZ"));
			prefab = bomb;
			ScoreManager.bomb = true;
			PlayerPrefs.SetInt ("BombUsing", 0);
		} 
		else 
		{
			prefab = simpleBall;
		}

		float x = Screen.width / 2;
		print (Screen.height);
		float y = Screen.height / 2;
		//		float y = 800f;
		//		Vector3 position = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, distance);
		Vector3 position = new Vector3 (x, y, distance);
		position = Camera.main.ScreenToWorldPoint (position);
		var go = Instantiate (prefab, child.transform.position, Quaternion.identity)as GameObject;
//		var go = Instantiate (prefab, new Vector3(-4f,17f,-58f), Quaternion.identity)as GameObject;
		go.transform.LookAt (position);
		Debug.Log (position);
		go.GetComponent<Rigidbody> ().AddForce (go.transform.forward * force);

		//		NetworkServer.Spawn (go);
		//		MouseDown = false;
		force = 500;


	}
}
