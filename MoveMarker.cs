using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MoveMarker : MonoBehaviour {

    // Use this for initialization
    public string btname;
    public string url = "http://teamstrixplasma-com.stackstaging.com/Multi/UserInfo/LevelSelect.php";
    public string username;
    public Text tex;
    public int i = 0;
    void Awake () {
        StartCoroutine(unlocklvl());
        
        


    }
	IEnumerator unlocklvl()
    {
        tex = GameObject.Find("LevelSelect").GetComponent<Text>();
        username = tex.text;
        WWWForm x = new WWWForm();
        x.AddField("username", username);
        WWW wWW = new WWW(url, x);
        yield return wWW;
        string urlinfo = wWW.text;
        btname = urlinfo;
        int y = int.Parse(btname);
        print(y);
        for (i = 1; i <= y+1; i++)
        {
            GameObject.Find(i + "").SetActive(true);
            print(i);
        }
        while (i <= 5)
        {
            GameObject.Find(i + "").SetActive(false);
            i++;
        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
