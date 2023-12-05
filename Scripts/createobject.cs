using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createobject : MonoBehaviour {

	// Use this for initialization
	public GameObject gobject;
	public Transform t1,t2,t3,t4;
	void Start () {
		if (PhotonNetwork.playerList.Length== 1) {
			PhotonNetwork.Instantiate (gobject.name, t1.position, t1.rotation, 0);
		}
		else if (PhotonNetwork.playerList.Length == 2) {
			PhotonNetwork.Instantiate (gobject.name, t2.position, t2.rotation, 0);
		}
		else if (PhotonNetwork.playerList.Length == 3) {
			PhotonNetwork.Instantiate (gobject.name, t3.position, t3.rotation, 0);
		}else if (PhotonNetwork.playerList.Length == 4) {
			PhotonNetwork.Instantiate (gobject.name, t4.position, t4.rotation, 0);
		}

	}

	// Update is called once per frame
	void Update () {

	}
}
