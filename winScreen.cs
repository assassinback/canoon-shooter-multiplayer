using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winScreen : MonoBehaviour {
	public GameObject LevelEndPanel;
	public GameObject Crosshair;
	public GameObject ScoreCanvas;
	GameObject parent;
	// Use this for initialization
	void Start () {
//		parent= GameObject.FindGameObjectWithTag ("MainCanvas").gameObject;
//		transform.parent = parent;
//		foreach
		Invoke ("Screens", 4.0f);

	}

	void Screens()
	{
		Crosshair.SetActive (false);
		ScoreCanvas.SetActive (false);
		LevelEndPanel.SetActive (true);
		Destroy (this.gameObject);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
