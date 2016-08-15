using UnityEngine;
using System.Collections;

public class UrlToTexture : MonoBehaviour {

	public string url;
	
	// Use this for initialization
	void Start () {
		if(url!="")	StartCoroutine(Download(url));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public IEnumerator Download (string url) {
		var www = new WWW (url);
		yield return www;
		GetComponent<Renderer>().material.mainTexture = www.texture;				
	}	
}
