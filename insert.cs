using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class insert : MonoBehaviour {
    public string url = "http://teamstrixplasma-com.stackstaging.com/Multi/UserInfo/userregister.php";
    public InputField username;
    public Text country;
    public Button signup;
    // Use this for initialization
    void Start () {
        signup.onClick.AddListener(Signup);
	}
    public void Signup()
    {
        WWWForm x = new WWWForm();
        x.AddField("username", username.text);
        x.AddField("Country", country.text);
        WWW wWW = new WWW(url, x);
        print("inserted");
        StartCoroutine(getData(wWW));

    }
    IEnumerator getData(WWW data)
    {
        yield return data;
        string itemdata = data.text;
        print(itemdata);
        if(itemdata=="Registered")
        SceneManager.LoadScene("NetworkLobby");

    }
    // Update is called once per frame
    void Update () {
		
	}
}
