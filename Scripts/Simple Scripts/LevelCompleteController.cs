using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompleteController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnNextLevel()
	{
		Scene currentScene = SceneManager.GetActiveScene ();
		if (currentScene.name[currentScene.name.Length-1]=='5') {
			print ("abc");
		} else {
			
		SceneManager.LoadScene (currentScene.buildIndex+1);

		}
	}

	public void RepeatLeavel()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);

	}
}
