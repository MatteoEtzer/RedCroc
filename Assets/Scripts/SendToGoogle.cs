using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class SendToGoogle : MonoBehaviour {

    public GameObject tuerklinke;
    public GameObject badewanne;

    private string Tuerklinke;
    private string Badewanne;

    [SerializeField]
    //private string BASE_URL = "https://docs.google.com/forms/u/0/d/e/1FAIpQLSeGQ8OZJqNaPKN5LXVIi-eMA6NAUPF2NG75fgzkqHpDnvMe9w/formResponse";
    private string BASE_URL = "https://docs.google.com/forms/u/0/d/e/1FAIpQLSeGQ8OZJqNaPKN5LXVIi-eMA6NAUPF2NG75fgzkqHpDnvMe9w/formResponse";


    IEnumerator Post(string tuerklinke, string badewanne) {
        WWWForm form = new WWWForm();
        form.AddField("entry.1672363601", tuerklinke);
        form.AddField("entry.1089729749", badewanne);
        
        
        byte[] rawData = form.data;
        WWW www = new WWW(BASE_URL, rawData);
        yield return www;
        
        // UnityWebRequest www = UnityWebRequest.Post(BASE_URL, form);
        // yield return www.SendWebRequest();

        // if (www.isNetworkError)
        // {
        //     Debug.Log(www.error);
        // }
        // else
        // {
        //     Debug.Log("Form upload complete!");
        // }
    }
    public void Send() {
        Tuerklinke = tuerklinke.GetComponent<InputField>().text;
        Badewanne = badewanne.GetComponent<InputField>().text;
        StartCoroutine(Post(Tuerklinke, Badewanne));

    }
}