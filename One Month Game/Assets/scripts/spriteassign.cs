using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spriteassign : MonoBehaviour {

	public SpriteRenderer spr;
	public Sprite s1;
	public Sprite s2;
	public Sprite s3;
	public Sprite s4;
	public Sprite s5;
	private playerscript ps;

	void Start()
	{
		ps = FindObjectOfType<playerscript> ();
	}

	// Update is called once per frame
	void Update () {
		if (0 == PlayerPrefs.GetInt ("Sprite")) {
			spr.sprite = s1;
		}
		if (1 == PlayerPrefs.GetInt ("Sprite")) {
			spr.sprite = s2;
		}
		if (2 == PlayerPrefs.GetInt ("Sprite")) {
			spr.sprite = s3;
		}
		if (3 == PlayerPrefs.GetInt ("Sprite")) {
			spr.sprite = s4;
		}
		if (3 == PlayerPrefs.GetInt ("Sprite") && ps.lives == 1) {
			spr.sprite = s5;
		}

	}
}
