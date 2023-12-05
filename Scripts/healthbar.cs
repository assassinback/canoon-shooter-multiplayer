using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbar : MonoBehaviour {

	public Slider healthindicator;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	float totalhealth=0;
	void OnTriggerEnter(Collider col)
	{
		
		if (col.tag=="Bullet") {
			totalhealth += 0.1f;
			healthindicator.value =totalhealth;
			print (healthindicator.value);
		}

		}

}
