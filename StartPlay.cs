using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartPlay : MonoBehaviour {


	public GameObject NetworkLobbycanvas;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SinglePlayerStart()
	{
		SceneManager.LoadScene (2);

	}

	public void MultiPlayerStart()
	{
		this.gameObject.SetActive (false);
		NetworkLobbycanvas.SetActive (true);
	}

}
