using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AnimateBar : MonoBehaviour {

    // Use this for initialization
    public Animator animator;
    public Image powerCover;
    float yPos = 0;
    float size = 443;
	void Start () {
        //animator.Play("powerbar");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {
            animator.enabled = true;
            animator.Play("powerbar");
        }
        if (Input.GetMouseButtonUp(0))
        {
            powerCover.rectTransform.anchoredPosition = new Vector2(powerCover.rectTransform.anchoredPosition.x, yPos);
            powerCover.rectTransform.sizeDelta = new Vector2(powerCover.rectTransform.sizeDelta.x, size);
            animator.Play("powerbar", -1, 0f);
            //animator.StopPlayback();
            animator.enabled = false;
            //powerCover.rectTransform.anchoredPosition.y = 0;
           

        }
	}
}
