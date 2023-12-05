using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class VerticalObjectThrower : NetworkBehaviour {

	public GameObject prefab;
	GameObject target;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("CmdLaunchVertical", 2, Random.Range(4,10));
	}

	// Update is called once per frame
	void Update () {
		if (!isLocalPlayer) {
			return;
		}

	}

	[Command]
	void CmdLaunchVertical()
	{
		if(!isServer)
		{return;}
		target=Instantiate (prefab, transform.position, Quaternion.identity) as GameObject;
		target.GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 3000, 0));
		NetworkServer.Spawn (target);
	}

}
