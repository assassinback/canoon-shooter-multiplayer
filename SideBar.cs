using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideBar : MonoBehaviour {


	public Animator SideBarAnimation;
	bool opened=false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void toggleSideBar()
	{
		if (!opened) {
			SideBarAnimation.Play ("SideBarOpen");
			opened = true;
		}
		else if (opened) {
			SideBarAnimation.Play ("SideBarClose");
			opened = false;

		}

	}
}
