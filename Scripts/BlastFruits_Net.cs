using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BlastFruits_Net : MonoBehaviour {

	public GameObject wall2;
	public GameObject wall1;
	public GameObject Fruit;

	public ParticleSystem Particlesystem;
	// Use this for initialization
	void Start () {
	//	Fruit = GameObject.FindGameObjectWithTag ("anim").gameObject;
//		Fruit = Resources.Load ("Layer 8") as GameObject;
//		gif = Fruit.GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {
		if (transform.position.y>400) {
			
			PhotonNetwork.Destroy (gameObject);

		}
	}

//	void OnTriggerExit(Collider col)
//	{
//
//		if (col.gameObject.tag=="Launcher") {
//			GetComponent<BoxCollider> ().isTrigger = false;
//			GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 0, 100	));
//			GetComponent<Rigidbody> ().AddTorque (new Vector3 (0, 0, 10));
//		}
//	}


	  
	GameObject canvas;
	Text Score;
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Bullet" || col.gameObject.tag == "Plane") {
//
//			wall2.SetActive (true);
//			wall1.SetActive (false);
//			GameObject anim = Instantiate (Fruit, gameObject.transform.position, Quaternion.identity);
//			gif.Play ("blast_anim");
//			//	Destroy (anim);
//			Invoke("DestroyFruit",3.0f);
//			 Instantiate(ParticleSystem,gameObject.transform.position,Quaternion.identity);
//			ParticleSystem.GetComponent<ParticleSystem>().Play();
			PhotonNetwork.Instantiate(Particlesystem.name,gameObject.transform.position,Quaternion.identity,0);
			ScoreManager.Score++;
		
			PhotonNetwork.Destroy (this.gameObject);
		
		}


	}

//	void DestroyFruit()
//	{
//		Destroy (this.gameObject);
//
//	}
}
