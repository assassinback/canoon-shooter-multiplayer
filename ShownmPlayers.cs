using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShownmPlayers : Photon.MonoBehaviour {

    // Use this for initialization
    public Text tex;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Room x = PhotonNetwork.room;
        tex.text = "RoomName:" + x.Name+"\n";
        tex.text += "Players:"+x.PlayerCount+"";
        if(x.PlayerCount==1)
        {
            PhotonNetwork.LoadLevel("GamePlay New");
        }
        if (x.MaxPlayers == 2 && x.PlayerCount == 2)
        {
            PhotonNetwork.LoadLevel("GamePlay New");
        }
        else if (x.MaxPlayers == 3 && x.PlayerCount == 3)
        {
            PhotonNetwork.LoadLevel("GamePlay New");
        }
        else if (x.MaxPlayers == 4 && x.PlayerCount == 4)
        {
            PhotonNetwork.LoadLevel("GamePlay New");
        }
    }
}
