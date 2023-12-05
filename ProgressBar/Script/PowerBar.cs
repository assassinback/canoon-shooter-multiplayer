using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[ExecuteInEditMode]

public class PowerBar : MonoBehaviour
{

    [Header("Title Setting")]
    public string Title;
    public Color TitleColor;
    public Font TitleFont;
    public int TitleFontSize = 10;

    [Header("Bar Setting")]
    public Color BarColor;   
    public Color BarBackGroundColor;
    public Sprite BarBackGroundSprite;
    [Range(1f, 100f)]
    public int Alert = 20;
	public Color BarAlertColor92;
	public Color BarAlertColor85;
	public Color BarAlertColor75;
    public Color BarAlertColor65;

    [Header("Sound Alert")]
    public AudioClip sound;
    public bool repeat = false;
    public float RepeatRate = 1f;

    private Image bar, barBackground;
    private float nextPlay;
    private AudioSource audiosource;
    private Text txtTitle;
    private float barValue;
    public float BarValue
    {
        get { return barValue; }

        set
        {
            value = Mathf.Clamp(value, 0, 100);
            barValue = value;
            UpdateValue(barValue);

        }
    }

        

    private void Awake()
    {
        bar = transform.Find("PowerBar").GetComponent<Image>();
        barBackground = GetComponent<Image>();
        barBackground = transform.Find("PowerBarBackground").GetComponent<Image>();
    }

    private void Start()
    {
//        txtTitle.text = Title;
//        txtTitle.color = TitleColor;
//        txtTitle.font = TitleFont;
//        txtTitle.fontSize = TitleFontSize;

        bar.color = BarColor;
        barBackground.color = BarBackGroundColor; 
        barBackground.sprite = BarBackGroundSprite;

        UpdateValue(barValue);


    }

    void UpdateValue(float val)
    {
//        bar.fillAmount = val / 100;
//        txtTitle.text = Title + " " + val + "%";
		if (val<65f) {

			bar.color = BarColor;
		}
		else if (val >= 92f)
		{
			bar.color = BarAlertColor92;
		}
		else if (val >= 85f)
		{
			bar.color = BarAlertColor85;
		}
		else if (val >= 75f)
		{
			bar.color = BarAlertColor75;
		}
		else if (val >= 65f)
        {
            bar.color = BarAlertColor65;
        }


    }


    private void Update()
    {
        if (!Application.isPlaying)
        {           
            UpdateValue(50);
//            txtTitle.color = TitleColor;
//            txtTitle.font = TitleFont;
//            txtTitle.fontSize = TitleFontSize;

            bar.color = BarColor;
            barBackground.color = BarBackGroundColor;

            barBackground.sprite = BarBackGroundSprite;           
        }
        else
        {
            if (Alert >= barValue && Time.time > nextPlay)
            {
                nextPlay = Time.time + RepeatRate;
//                audiosource.PlayOneShot(sound);
            }
        }
    }

}
