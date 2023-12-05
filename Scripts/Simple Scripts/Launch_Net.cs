using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launch_Net : MonoBehaviour {

	public GameObject prefab;


	// Use this for initialization
	void Start () 
	{
		//PhotonNetwork.RPC ("launchingball", PhotonTargets.All, null);
		if(PhotonNetwork.player.ID==1)
		{
			InvokeRepeating ("launchingball", 4.0f, 4.0f);
		} 

	}

	// Update is called once per frame
	void Update () {
	}

	[PunRPC]void launchingball()
	{

		GameObject projectile = PhotonNetwork.Instantiate (prefab.name,this.transform.position,this.transform.rotation,0);
		//projectile.transform.position = transform.position;
		Rigidbody rb = projectile.GetComponent<Rigidbody> ();
		rb.velocity = new Vector3(0,50,0);
	}

}
