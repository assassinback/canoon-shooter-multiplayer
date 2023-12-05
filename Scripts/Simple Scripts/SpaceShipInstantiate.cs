using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipInstantiate : MonoBehaviour {

	public GameObject Spaceship;
	public float SpaceshipSpeedDown;
	// Use this for initialization
	void Start () {
		Invoke ("CreateSpaceship", 4.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void CreateSpaceship()
	{
//		GameObject Spaceship= Instantiate (spaceshipPrefab, transform.position,spaceshipPrefab.transform.rotation);
		Spaceship.GetComponent<Rigidbody> ().velocity = Vector3.down * SpaceshipSpeedDown*Time.deltaTime;
        
	}
}
