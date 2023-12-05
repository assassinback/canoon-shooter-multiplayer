using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Joystcik : MonoBehaviour,IPointerDownHandler,IPointerUpHandler{

	public GameObject Crosshair;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnPointerUp(PointerEventData eventData)
	{
		Crosshair.GetComponent<crossHairRotation> ().enabled = false;

	}
	public void OnPointerDown(PointerEventData eventData)
	{
		Crosshair.GetComponent<crossHairRotation> ().enabled = true;
	}
}
