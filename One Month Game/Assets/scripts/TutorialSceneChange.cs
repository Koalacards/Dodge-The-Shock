using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialSceneChange : MonoBehaviour {

	// Use this for initialization
	void Start () {
		PlayerPrefs.GetInt ("TutorialDone");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ChangeScene()
	{
		if (0 == PlayerPrefs.GetInt ("TutorialDone")) {
			SceneManager.LoadScene ("tutorial");
			PlayerPrefs.SetInt ("TutorialDone", 1);
		}
		if (1 == PlayerPrefs.GetInt ("TutorialDone")) {
			SceneManager.LoadScene ("mainscene");
		}
	}
}
