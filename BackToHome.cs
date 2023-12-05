using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BackToHome : MonoBehaviour {


	public GameObject HomeScreenPanel;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnBack()
	{
		this.gameObject.SetActive (false);
		HomeScreenPanel.SetActive (true);

	}

	public void BackTohomeScene(int sceneindex)
	{
		SceneManager.LoadScene (sceneindex);
	}
}
