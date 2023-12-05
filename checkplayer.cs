using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class checkplayer : MonoBehaviour {

    // Use this for initialization
    int firstTime;
    public string username;
    public Button button;
    void Awake()
    {
        PlayerPrefs.SetInt("firstTime", 0);
        DontDestroyOnLoad(this.gameObject);
        firstTime = PlayerPrefs.GetInt("firstTime");
        if(firstTime == 1)
        {
            if (Application.internetReachability == NetworkReachability.NotReachable)
            {
                print("Error Internet Connection not found");
                button.enabled = false;
            }
            else
            {
                
                SceneManager.LoadScene("NetworkLobby");
                username = PlayerPrefs.GetString("username");
            }
        }
        else
        {
            
        }
    }
    public void onclik()
    {
        PlayerPrefs.SetInt("firstTime",1);
        username = PlayerPrefs.GetString("username");
        //SceneManager.LoadScene("NetworkLobby");
        // FbTest x = new FbTest();
        // x.GetFriendsPlayingThisGame();
        Destroy(this.gameObject);
    }
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
