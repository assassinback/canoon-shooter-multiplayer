using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
public class Collectscore : Photon.MonoBehaviour {
    public Text p1s, p2s, p3s, p4s;
    PhotonView[] mine;
    GameObject[] gobject;
    public int j = 0;
    public int i=0;
    public int k = 0;
    public string url = "http://teamstrixplasma-com.stackstaging.com/Multi/UserInfo/SaveGamesWon.php";
    public string url1 = "http://teamstrixplasma-com.stackstaging.com/Multi/UserInfo/SaveGamePlayed.php";
    // Use this for initialization
    public giveScore give;
    public int[] a;
	void Start () {
        give = GameObject.Find("Scores").GetComponent<giveScore>();
        a = new int[4];
        mine = new PhotonView[4];
        gobject = new GameObject[4];
        //mine = GameObject.Find("Viking_DefenseCannon(Clone)").GetComponent<PhotonView>();
        gobject= GameObject.FindGameObjectsWithTag("Cannon");
        try
        {
            for (k = 0; k < gobject.Length; k++)
            {
                mine[k] = gobject[k].GetComponent<PhotonView>();
            }
        }
        catch (System.Exception) { }
        try
        {
            for (k = 0; k < gobject.Length; k++)
            {
                if (mine[k].isMine)
                {
                    break;
                }
            }
        }
        catch (System.Exception) { }
	}
	
	// Update is called once per frame
	void Update () {
        if(i==0)
        { 
        Room x = PhotonNetwork.room;

        p1s.text = give.p1;
        p2s.text = give.p2;
        if (x.MaxPlayers == 4)
        {
            p3s.text = give.p3;
            p4s.text = give.p4;
        }
        a[0] = int.Parse(give.p1);
        a[1] = int.Parse(give.p2);
        a[2] = int.Parse(give.p3);
        a[3] = int.Parse(give.p4);
        //for(int i=0;i<4;i++)
        //{
        //    for(int j=0;j<4; j++)
        //    {
        //        if(a[i]<a[j])
        //        {
        //            int temp = a[i];
        //            a[i] = a[j];
        //            a[j] = temp;
        //        }
        //    }
        //}
        int maxValue = a.Max();
        int maxIndex = a.ToList().IndexOf(maxValue);
        if (maxIndex==0)
        {
            if(mine[k].isMine)
            {
                StartCoroutine(winner("p1"));
                    i = 1;
            }
        }
        else if (maxIndex == 1)
        {
            if (mine[k].isMine)
            {
                StartCoroutine(winner("p1"));
                    i = 1;
            }
        }
        else if (maxIndex == 2)
        {
            if (mine[k].isMine)
            {
                StartCoroutine(winner("p1"));
                    i = 1;
            }
        }
        else if (maxIndex == 3)
        {
            if (mine[k].isMine)
            {
                StartCoroutine(winner("p1"));
                    i = 1;
            }
        }
            if (j == 0)
            {
                if (mine[k].isMine)
                {
                    j = 1;
                    StartCoroutine(saveplayed());
                }
            }
        }
        
    }
    IEnumerator saveplayed()
    {
        if(mine[k].isMine)
        {
            WWWForm x = new WWWForm();
            x.AddField("username", PlayerPrefs.GetString("username"));
            WWW wWW = new WWW(url1, x);
            yield return wWW;
        }
    }
    IEnumerator winner(string winnername)
    {
        WWWForm x = new WWWForm();
        x.AddField("username", PlayerPrefs.GetString("username"));
        WWW wWW = new WWW(url, x);
        yield return wWW;
    }
}
