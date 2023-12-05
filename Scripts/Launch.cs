using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launch : MonoBehaviour {

	public GameObject prefab;
//	public PhotonView pmain;
	float min= 2.0f;
    float max=5;
	float speed=30;
	bool onceupdate=false;
	// Use this for initialization
	void Start () 
	{
//		if (pmain.) {
//			
//		}
		PlayerPrefs.SetInt ("FreezeTimeMaxToUse", PlayerPrefs.GetInt ("FreezeTimeNormalMax"));
		PlayerPrefs.SetInt("FreezeTimeSpeedToUse",PlayerPrefs.GetInt("FreezeTimeNormalSpeed"));
		InvokeRepeating ("launchingball", 5.0f, Random.Range(min,PlayerPrefs.GetInt("FreezeTimeMaxToUse")));
	}
	
	// Update is called once per frame
	void Update () {


	}

	void launchingball()
	{
		int num = Random.Range (1, 10);
		GameObject projectile = Instantiate (prefab,transform.position,prefab.transform.rotation)as GameObject;
		if (num<=8) {
			projectile.tag="NormalToys";
		} 
		else {
			projectile.tag="RareToys";

		}
		projectile.transform.position = transform.position;
		Rigidbody rb = projectile.GetComponent<Rigidbody> ();
		rb.velocity = new Vector3(0,PlayerPrefs.GetInt("FreezeTimeSpeedToUse"),0);
		rb.AddTorque(new Vector3(200,200,200));

//		int velnum = Random.Range (0, 15);
//		if (velnum > 5) {
//			rb.velocity = new Vector3(-5,60,5);
//
//		} else if (velnum>10){
//
//			rb.velocity = new Vector3(5,40,-5);
//
//		} else {
//			rb.velocity = new Vector3(2,20,2);
//
//		}

//		rb.AddTorque(new Vector3(10,10,10));
	}

}
