using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class create : MonoBehaviour {
	public InputField Create,joina;
	// Use this for initialization
	void Start()
	{

	}
	public void onclickcreate () {
		PhotonNetwork.CreateRoom (Create.text, new RoomOptions (){ MaxPlayers = 4 }, null);
	}
	public void onclickjoin()
	{
		PhotonNetwork.JoinOrCreateRoom(joina.text,new RoomOptions(){MaxPlayers=4},TypedLobby.Default);
	}
	public void onclickjoinQuickMatch() {

		//PhotonNetwork.JoinOrCreateRoom(joina.text,new RoomOptions(){MaxPlayers=4},TypedLobby.Default);
		Hashtable expectedCustomRoomProperties = new Hashtable()
		{
			{ "Color","brown2" },
			{"Level", "1" }
		};
		PhotonNetwork.JoinRandomRoom(null,4);
	}
    public string genRandom()
    {
        string c = "abcdefghijklmnopqrstuvwxyzABCDEFGHIKLMNOPQRSTUVWXYZ";
        string[] a=new string[4];
        string d = "";
        for (int i = 0; i < 4; i++)
        {
            Random x = new Random();
            a[i] = c.Substring(Random.Range(0,100000) % c.Length, 1);
        }
        for (int i = 0; i < 4; i++)
        {
            d += a[i];
        }
        return d;
    }
    void OnPhotonRandomJoinFailed()
	{   
		PhotonNetwork.CreateRoom (genRandom(), new RoomOptions (){ MaxPlayers = 4 }, null);
	}
	// Update is called once per frame
	void Update () {

	}
	void OnJoinedRoom()
	{
		PhotonNetwork.LoadLevel ("WaitingForPlayers");
        
	}
}
