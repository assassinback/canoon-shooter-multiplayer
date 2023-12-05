using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class checkloggedin : MonoBehaviour {

    // Use this for initialization
    public int level;
    public string guestname;
	void Start () {
        
	}
	public void onclik()
    {
        Destroy(GameObject.Find("LoggedIn"));
        PlayerPrefs.SetInt("firstTime", 0);
        if(PlayerPrefs.GetInt("exists")==0)
        {
            PlayerPrefs.SetInt("exists", 1);
            PlayerPrefs.SetInt("currentlevel",1);
            level = PlayerPrefs.GetInt("currentlevel");
            PlayerPrefs.SetString("GuestName","Guest"+(Random.value*10000));
            guestname = PlayerPrefs.GetString("GuestName");
        }
        else
        {
            level=PlayerPrefs.GetInt("currentlevel");
            guestname = PlayerPrefs.GetString("GuestName");
            SceneManager.LoadScene("NetworkLobbyGuest");
        }

    }
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
