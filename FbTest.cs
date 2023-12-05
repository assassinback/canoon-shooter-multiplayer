using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using Facebook.Unity;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class FbTest : MonoBehaviour {

	// Use this for initialization
	public Text FriendsText;
    public string url = "http://teamstrixplasma-com.stackstaging.com/Multi/UserInfo/Getusername.php";
    //public Text tex;
	private void Awake(){
		DontDestroyOnLoad(this.gameObject);
        
		if(!FB.IsInitialized){
			FB.Init(()=>{
				if(FB.IsInitialized){
					print("fb init");
					FB.ActivateApp();
				}
					
				else
				{
					Debug.Log("Couldn't initialize");
				}
			},
			isGameShown => 
			{
				if(!isGameShown)
					Time.timeScale = 0;
				else
					Time.timeScale=1;
			}
			);
		}
		else
		{
			FB.ActivateApp();
		}

	}
	private void Update(){
		if(GameObject.Find("getfriends")!=null)
        {
            FriendsText = GameObject.Find("getfriends").GetComponent<Text>();
            GetFriendsPlayingThisGame();
        }
	}
    
	#region Login/Logout
	public void FacebookLogin()
    {
		var permissions = new List<string>(){"public_profile","email","user_friends"};
		FB.LogInWithReadPermissions(permissions,AuthCallback);
        //SceneManager.LoadScene(sceneName);
    }
	private void AuthCallback(ILoginResult result){
		if(FB.IsLoggedIn){
			//SceneManager.LoadScene(9);
            if(PlayerPrefs.GetString("username")=="")
            {
                SceneManager.LoadScene("Register");
            }
            else if(PlayerPrefs.GetString("username").Length>=1)
            {
                StartCoroutine(GetName());
            }
		}
		else{
			SceneManager.LoadScene(6);
		}
	}
    IEnumerator GetName()
    {
        WWWForm X = new WWWForm();
        X.AddField("username",PlayerPrefs.GetString("username"));
        WWW wWW = new WWW(url, X);
        yield return wWW;
        string x = wWW.text;
        if(x=="0")
        {
            SceneManager.LoadScene("NetworkLobby");
        }
        else
        {
			SceneManager.LoadScene("Register");
            
        }

    }
	public void FacebookLogout(){
		FB.LogOut();
        if(GameObject.Find("username")!=null)
        {
            Destroy(GameObject.Find("username"));
        }
	}
    public void loginguest(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
	#endregion
	public void FacebookShare(){
		FB.ShareLink(new System.Uri("http://resocoder.com"),"Check it out","Good programming tutorials",new System.Uri("http://resocoder.com/wp-content/uploads/2017/01/logoRound512.png"));
		
	}
	#region Inviting
	public void FacebookGameRequest(){
		FB.AppRequest("Hey come and play this game",title: "Reso coder tutorial");
	}
	#endregion
	public void GetFriendsPlayingThisGame(){
        FriendsText = GameObject.Find("Names").GetComponent<Text>();
        string query = "/me/friends";
        FB.API(query, HttpMethod.GET, result =>
        {
            var dictionary = (Dictionary<string, object>)Facebook.MiniJSON.Json.Deserialize(result.RawResult);
            var friendsList = (List<object>)dictionary["data"];
            FriendsText.text = string.Empty;
            //FriendsText.text = result.RawResult;
            print(FriendsText.text);
            foreach (var dict in friendsList)
                FriendsText.text += ((Dictionary<string, object>)dict)["name"];
        });
    }
}
