using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deathMenu : MonoBehaviour {
    public Text jj;
	// Use this for initialization
	void Start () {
        //  gameObject.SetActive(false);
        jj.text = PlayerPrefs.GetString("xxx");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void deathScore(string Finalscore)
    {
        jj.text = Finalscore;
       // gameObject.SetActive(true);
    }
}
