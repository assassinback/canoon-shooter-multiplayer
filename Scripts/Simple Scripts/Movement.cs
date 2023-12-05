	using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
	public Transform lookAt;
	public Transform camTransform;

	public Camera cam;

	public float distance = 100.0f;
	public float SpeedH = 2.0f;
	public float SpeedV = 2.0f;
	public float pow = 0.0f;
	public float pitch = 0.0f;


	public Vector2 RunAxis;
	public bool Jump;
	// Use this for initialization
	void Start () {
		camTransform = transform;
		cam = Camera.main;
	}

	void Update()
	{
//			pow += SpeedH * RunAxis.x;
//		pitch += SpeedV * RunAxis.y;
		pow += SpeedH * Input.GetAxis ("Mouse X");
		pitch += SpeedV * Input.GetAxis ("Mouse Y");

		transform.eulerAngles = new Vector3 (-pitch, pow, 0.0f);
		//lookAt.transform.eulerAngles = new Vector3 (-pitch, pow, 0.0f);
	}
	// Update is called once per frame

}
