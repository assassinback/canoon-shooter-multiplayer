using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class gotoScene : MonoBehaviour {

    // Use this for initialization
    public InputField input;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Loggedin(string sceneName)
    {
        PlayerPrefs.SetString("username",input.text);
        SceneManager.LoadScene(sceneName);
    }
    public void Loggedin1(string sceneName)
    {
        PlayerPrefs.SetInt("firstTime", 0);
        SceneManager.LoadScene(sceneName);
    }
    public void Loggedin2()
    {
        PlayerPrefs.SetString("username", input.text);
    }

}
