using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class storemenucoins : MonoBehaviour {

	public Text cointext;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		cointext.text = "Coins: " + PlayerPrefs.GetInt ("Coincount");
	}
}
