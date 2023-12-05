using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class multiplayertimer : MonoBehaviour {

    // Use this for initialization
    public Text timetext;
    public float i= 0;
    public float j = 0;
	void Start () {
        i = 60;
	}
	
	// Update is called once per frame
	void Update () {
        timetext.text = "Time Left:"+Mathf.Floor(i) + "";
        j += Time.deltaTime;
        if(j>=1)
        {
            j = 0;
            i--;
        }
        if(i==0)
        {
            PhotonNetwork.LoadLevel("Results");
        }
	}
}
