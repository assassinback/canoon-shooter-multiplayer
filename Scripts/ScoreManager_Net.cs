using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager_Net : Photon.MonoBehaviour {

	// Use this for initialization
	public PhotonView a;

	void Start () {
		//a.RPC("p1rpc",PhotonTargets.All,"5");


	}
	void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
		// if(stream.isWriting)
		// {
		// 	if(PhotonNetwork.player.ID==1){
		// 		int x=int.Parse(GameObject.Find("p1").GetComponent<Text>().text);
		// 		x++;
		// 		GameObject.Find("p1").GetComponent<Text>().text=x+"";
		// 		stream.SendNext(GameObject.Find("p1").GetComponent<Text>());
		// 	}
		// 	if(PhotonNetwork.player.ID==2){
		// 		int x=int.Parse(GameObject.Find("p2").GetComponent<Text>().text);
		// 		x++;
		// 		GameObject.Find("p2").GetComponent<Text>().text=x+"";
		// 		stream.SendNext(GameObject.Find("p2").GetComponent<Text>());
		// 	}
		// 	if(PhotonNetwork.player.ID==3){
		// 		int x=int.Parse(GameObject.Find("p3").GetComponent<Text>().text);
		// 		x++;
		// 		GameObject.Find("p3").GetComponent<Text>().text=x+"";
		// 		stream.SendNext(GameObject.Find("p3").GetComponent<Text>());
		// 	}
		// 	if(PhotonNetwork.player.ID==4){
		// 		int x=int.Parse(GameObject.Find("p4").GetComponent<Text>().text);
		// 		x++;
		// 		GameObject.Find("p4").GetComponent<Text>().text=x+"";
		// 		stream.SendNext(GameObject.Find("p4").GetComponent<Text>());
		// 	}
		// }
	}
	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.tag=="Target")
		{

			if(PhotonNetwork.player.ID==1)
			{

				a.RPC("p1rpc",PhotonTargets.All,null);
			}
			if(PhotonNetwork.player.ID==2)
			{
				a.RPC("p2rpc",PhotonTargets.All,null);
			}
			if(PhotonNetwork.player.ID==3)
			{
				a.RPC("p3rpc",PhotonTargets.All,null);

			}
			if(PhotonNetwork.player.ID==4)
			{
				a.RPC("p4rpc",PhotonTargets.All,null);

			}
			PhotonNetwork.Destroy(this.gameObject);

		}
	}
	// Update is called once per frame
	void Update () {

	}


	[PunRPC]void p1rpc()
	{
		int x=int.Parse(GameObject.Find("Player 1 Score").GetComponent<Text>().text);
		x++;
		GameObject.Find("Player 1 Score").GetComponent<Text>().text=x+"";
	}

	[PunRPC]void p2rpc()
	{
		int x=int.Parse(GameObject.Find("Player 2 Score").GetComponent<Text>().text);
		x++;
		GameObject.Find("Player 2 Score").GetComponent<Text>().text=x+"";
	}

	[PunRPC]void p3rpc()
	{
		int x=int.Parse(GameObject.Find("Player 3 Score").GetComponent<Text>().text);
		x++;
		GameObject.Find("Player 3 Score").GetComponent<Text>().text=x+"";
	}

	[PunRPC]void p4rpc()
	{
		int x=int.Parse(GameObject.Find("Player 4 Score").GetComponent<Text>().text);
		x++;
		GameObject.Find("Player 4 Score").GetComponent<Text>().text=x+"";
	}
}
