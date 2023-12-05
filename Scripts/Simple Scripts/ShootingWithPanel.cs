	using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.PostProcessing;
using UnityEngine.EventSystems;
public class ShootingWithPanel : MonoBehaviour,IPointerUpHandler,IPointerDownHandler {

	public Sprite InactiveButton;
	public Sprite ActiveButton;
	public GameObject AnotherButton;
	bool MouseDown;
	float Force=5000;
	float MaxForce=30000;
	public GameObject prefab;
	public GameObject attacker;
	public Animator animator;
	public Image powerCover;
	float yPos = 0;
	float size = 443;
//	public Animator Vibration;
//	public GameObject Camera;
//	public PostProcessingProfile cc;
//	public GameObject Enviroment;
//	Vector3 EnviromentStartingPosition;
//	Vector3 EnviromentStartingScale;
//	Vector3 CameraStartingPosition;
	public float backspeed;
//	float BACK=0;
//	public ProgressBar Pb;

	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt ("MyScore", 1000);
//		Pb.BarValue = 100f;
//		EnviromentStartingPosition = Enviroment.transform.position;
//		EnviromentStartingScale = Enviroment.transform.localScale;
//		CameraStartingPosition = Camera.transform.position;
	}
	
	// Update is called once per frame
	void Update () {

		if (MouseDown) {
			if (Force<=MaxForce) {

			Force += 500;
//				Enviroment.transform.position = Vector3.back * backspeed * Time.deltaTime;

//				if (BACK>=-2.0f) {

//				Enviroment.transform.position = new Vector3(Enviroment.transform.localPosition.x,Enviroment.transform.localPosition.y,Enviroment.transform.localPosition.z-BACK);
//					Enviroment.transform.localScale = new Vector3 (Enviroment.transform.localScale.x - 0.01f, Enviroment.transform.localScale.y - 0.01f, Enviroment.transform.localScale.z - 0.01f);
//				Camera.transform.position = new Vector3(Camera.transform.localPosition.x,Camera.transform.localPosition.y,Camera.transform.localPosition.z+BACK);
//					BACK-=0.5F;	
//				}
//				else if (BACK<=-2.0f) {
//					Vibration.Play ("CanonShake");
//				}
					//			Pb.BarValue -= 5f;	
//				print (Pb.BarValue);

			}
		}		
	}

	public void OnPointerUp(PointerEventData eventData)
	{
//		cc.motionBlur.enabled=false;
		attacker.GetComponent<Attack> (). AttackShoot(Force);

		GetComponent<Image> ().sprite = InactiveButton;
		GetComponent<RectTransform> ().sizeDelta = new Vector2 (228, 228);
		powerCover.rectTransform.anchoredPosition = new Vector2(powerCover.rectTransform.anchoredPosition.x, yPos);
		powerCover.rectTransform.sizeDelta = new Vector2(powerCover.rectTransform.sizeDelta.x, size);
		animator.Play("powerbar", -1, 0f);
		//animator.StopPlayback();
		animator.enabled = false;
//		Enviroment.transform.position = EnviromentStartingPosition;
//		Vibration.enabled = false;
//		Enviroment.transform.localScale = EnviromentStartingScale;
//		Camera.transform.position = CameraStartingPosition;
		Force = 5000;
//		BACK = 0;
//		Pb.BarValue=100f;	
		MouseDown = false;
//		this.enabled = false;


	}

	public void OnPointerDown(PointerEventData eventData)
	{
//		Vibration.enabled = true;
		//		cc.motionBlur.enabled = true; 
		animator.enabled = true;
		animator.Play("powerbar");
		GetComponent<Image> ().sprite = ActiveButton;
		GetComponent<RectTransform> ().sizeDelta = new Vector2 (194, 194);
			
		MouseDown = true;

	}
}
