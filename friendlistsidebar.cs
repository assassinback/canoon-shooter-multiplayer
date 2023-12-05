using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class friendlistsidebar : MonoBehaviour {

    // Use this for initialization
    public Animator sidebar;
    public bool isopened = false;
    public Button btn;
	void Start () {
        btn.onClick.AddListener(click);
	}
	public void click()
    {
        if(isopened==false)
        {
            sidebar.Play("Opened");
            isopened = true;
        }
        else
        {
            sidebar.Play("Closed");
            isopened = false;
        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
