using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BackToPlayScreen : MonoBehaviour {

	// Use this for initialization
	public GameObject PlayScreenCanvas;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Back()
	{		
		
		this.gameObject.SetActive (false);
		PlayScreenCanvas.SetActive (true);
	}
}
