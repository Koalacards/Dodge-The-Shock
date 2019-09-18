using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenechange: MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void SceneToChangeTo(string scene)
	{
		SceneManager.LoadScene (scene);
	}

	public void ExitGame()
	{
		Application.Quit ();
	}
}
