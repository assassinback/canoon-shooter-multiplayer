using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChange : MonoBehaviour {

	// Use this for initialization
	int hasPlayed;
	void Awake(){
		hasPlayed = PlayerPrefs.GetInt("HasPlayed");
	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnPlayClickLevel1(int SceneNo){
//		if(hasPlayed == 0){
//			SceneManager.LoadScene(9);
//			PlayerPrefs.SetInt("HasPlayed",1);
//		}
//		else{
//		if (gameObject.name=="Level 1") {
//			
//		}
//			SceneManager.LoadScene(2);
//		}
		SceneManager.LoadScene(SceneNo);
	}
	IEnumerator ChangeOfScene(){
		yield return new WaitForSeconds(2.0f);
		SceneManager.LoadScene(2);
	}
}
