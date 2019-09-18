using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainmenuhighschore : MonoBehaviour {

	public Text highscoretext;
	void Start () {
		highscoretext.text = "Highscore: " + PlayerPrefs.GetInt ("Highscore");
	}

	void Update () {
		
	}
}
