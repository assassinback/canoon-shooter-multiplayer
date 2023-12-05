using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OnClickShoot : MonoBehaviour,IPointerClickHandler{

	public GameObject Canon;
	// Use this for initialization
	void Start () {
		Canon = Resources.Load ("canon") as GameObject;
	}
	public bool mouseDown,mouseUp,OncemouseUp,OncemouseDown,mouseClicked;
	// Update is called once per frame
	void Update () {
		if (OncemouseUp) {
			mouseUp = false;
		}
//		if (mouseDown) {
//			mouseClicked = true;
//		}
	}

	public void OnPointerClick(PointerEventData eventData){
//			mouseDown = true;
//			OncemouseUp = false;
		Canon.GetComponent<AttackShoot_Net> ().CmdAttack ();

	
	}


//	public void OnPointerUp(PointerEventData eventData){
//		if (!OncemouseUp) {
//			mouseUp = true;
//			mouseDown = false;
//			OncemouseUp = true;
//		}
//	}
}
