using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TryConnecting : MonoBehaviour {

	// Use this for initialization
	public string versionName="0.1";
	//public GameObject gObject1,gObject2,gObject3;
	public void Start()
	{
		DontDestroyOnLoad (this.gameObject);
		PhotonNetwork.ConnectUsingSettings (versionName);
		Debug.Log ("Connecting to Photon");

	}
	public void OnConnectedToMaster()
	{
		PhotonNetwork.JoinLobby (TypedLobby.Default);
		Debug.Log ("We Are connected to master");
	}
	private void OnJoinedLobby()
	{
		//gObject2.SetActive (true);
		//gObject1.SetActive (false);
		Debug.Log ("On Joined Lobby");

	}
	private void OnDisconnectedFromPhoton()
	{
		//gObject2.SetActive (false);
		//gObject3.SetActive (true);
		Debug.Log ("Dis from photon services");
	}

	// Update is called once per frame
	void Update () {

	}
}
