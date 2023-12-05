using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipAtacked : MonoBehaviour {

	public ParticleSystem particlesystem;
	public float SpaceshipSpeed;
	public GameObject ChildCarrier;
	public GameObject CapturedObjectprefab;
	GameObject CapturedObject;
//	public ProgressBar Pb;


	// Use this for initialization
	void Start () {
//		Pb.BarValue = 100;

	}
	Transform currentposition;
	// Update is called once per frame
	void Update () {
		currentposition = transform;
	}
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag=="Bullet") {
			ParticleSystem fire= Instantiate (particlesystem, col.gameObject.transform.position, Quaternion.identity);
			fire.transform.parent = transform;
			Destroy (col.gameObject);
			print(col.gameObject.GetComponent<Rigidbody> ().velocity.magnitude);
//			if () {
//				
//			}
//			Pb.BarValue -= 13;
				//            PbC.BarValue -= 1;


		}
		if (col.gameObject.tag=="Terrain") {
			GetComponent<Rigidbody> ().velocity = Vector3.up * Time.deltaTime * SpaceshipSpeed;
			CapturedObject=	Instantiate (CapturedObjectprefab, ChildCarrier.transform.position, Quaternion.identity, gameObject.transform);

		}
		if (col.gameObject.tag=="SpaceShiplight") {
			GetComponent<Rigidbody> ().velocity = Vector3.down * Time.deltaTime * SpaceshipSpeed;
			Destroy (CapturedObject);
		}
	}
}
