using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class BlastFruits : MonoBehaviour {

	public GameObject wall2;
	public GameObject wall1;
	public GameObject Fruit;
	public GameObject Coin;
	int coinsValue;
	float TotalTime;
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
			
			Destroy (gameObject);

		}

			GetComponent<Rigidbody>().velocity = new Vector3(0,PlayerPrefs.GetInt("FreezeTimeSpeedToUse"),0);

	
//			if (ScoreManager.TotalTime<= PlayerPrefs.GetFloat("MultiplyScoreTime")) {
//				ScoreManager.TotalTime += Time.deltaTime;
//			} else {
//				PlayerPrefs.SetInt ("MultiplyScoreUsing", 0);
//			}
//		} 
//		else {
//			coinsValue = 10;
//		}
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
	public void OnCollisionEnter(Collision col)
	{
		
		
		destroyBox (col.gameObject);
//		if (col.gameObject.tag == "Bomb") {
//			Destroy (col.gameObject);
//		}

	}


public void destroyBox( GameObject col)
	{
	if (col.gameObject.tag == "Bullet" || col.gameObject.tag == "Plane"||col.gameObject.tag == "Bomb") {
		//
		//			wall2.SetActive (true);
		//			wall1.SetActive (false);
		//			GameObject anim = Instantiate (Fruit, gameObject.transform.position, Quaternion.identity);
		//			gif.Play ("blast_anim");
		//			//	Destroy (anim);
		//			Invoke("DestroyFruit",3.0f);
		//			 Instantiate(ParticleSystem,gameObject.transform.position,Quaternion.identity);
		//			ParticleSystem.GetComponent<ParticleSystem>().Play();
		Instantiate(Particlesystem,gameObject.transform.position,Quaternion.identity);
		GameObject Coins1= Instantiate(Coin,gameObject.transform.position,Coin.transform.rotation);
		GameObject Coins2= Instantiate(Coin,gameObject.transform.position,Coin.transform.rotation);
		GameObject Coins3= Instantiate(Coin,gameObject.transform.position,Coin.transform.rotation);
		GameObject Coins4= Instantiate(Coin,gameObject.transform.position,Coin.transform.rotation);
		Coins1.GetComponent<Rigidbody> ().AddForce(new Vector3(100,400,0));
		Coins1.GetComponent<Rigidbody> ().AddTorque(new Vector3(-200,50,200));
		Coins2.GetComponent<Rigidbody> ().AddForce(new Vector3(0,400,100));
		Coins2.GetComponent<Rigidbody> ().AddTorque(new Vector3(200,50,-200));
		Coins3.GetComponent<Rigidbody> ().AddForce(new Vector3(-100,400,0));
		Coins3.GetComponent<Rigidbody> ().AddTorque(new Vector3(-200,50,-200));
		Coins4.GetComponent<Rigidbody> ().AddForce(new Vector3(0,400,-100));
		Coins4.GetComponent<Rigidbody> ().AddTorque(new Vector3(200,50,200));

			if (PlayerPrefs.GetInt ("MultiplyScoreUsing") == 1) {
				coinsValue = PlayerPrefs.GetInt ("MultiplyScoreValue");
			} else {
				coinsValue = 10;
			}

			if (this.gameObject.tag=="NormalToys") {
				PlayerPrefs.SetInt ("TotalNormalToysCollected", PlayerPrefs.GetInt("TotalNormalToysCollected")+1);

			}

			else if (this.gameObject.tag=="RareToys") {
				PlayerPrefs.SetInt ("TotalRareToysCollected", PlayerPrefs.GetInt("TotalRareToysCollected")+1);		
			}
			else if (this.gameObject.tag=="SpaceShips") {
				PlayerPrefs.SetInt ("TotalShipsDestroyed", PlayerPrefs.GetInt("TotalShipsDestroyed")+1);		
			}
			PlayerPrefs.SetInt ("MyScore", PlayerPrefs.GetInt ("MyScore") + coinsValue);
		ScoreManager.Score++;

		Destroy (this.gameObject);
	}
}
}
