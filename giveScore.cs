using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class giveScore : Photon.MonoBehaviour {
    public Text p1score, p2score, p3score, p4score;
    public string p1="", p2="", p3="", p4="";
    // Use this for initialization
    void Start () {
        DontDestroyOnLoad(this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
        Room x = PhotonNetwork.room;
        if(x.MaxPlayers==2)
        {
            try
            {
                p1 = p1score.text;
                p2 = p2score.text;
            }
            catch (System.Exception) { }
        }
        else if(x.MaxPlayers==4)
        {
            try
            {
                p1 = p1score.text;
                p2 = p2score.text;
                p3 = p3score.text;
                p4 = p4score.text;
            }
            catch (System.Exception) { }
        }
    }
}
