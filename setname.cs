using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class setname : MonoBehaviour {

    // Use this for initialization
    public GameObject pname;
    public Text username;
	void Start () {
        username = GetComponent<Text>();
        if (GameObject.Find("LoggedIn") != null)
        {
            pname = GameObject.Find("LoggedIn");
            print(PlayerPrefs.GetString("username"));
            username.text = PlayerPrefs.GetString("username");
        }
        else
        {
            pname = GameObject.Find("guestloggedin");
            username.text = PlayerPrefs.GetString("GuestName");
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
