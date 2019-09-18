using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class spawnobjects : MonoBehaviour {

	public GameObject[] obstacles;

	private playerscript player;

	private triggerscript trs;

    float waittime;

	public Canvas gameCanvas;

	public Canvas overCanvas;

	public Canvas EndCanvas;


	// Use this for initialization
	void Start () {
		player = FindObjectOfType<playerscript> ();
		trs = FindObjectOfType<triggerscript> ();
		waittime = Random.Range (1.6f, 2f);
		Invoke ("SpawnObstacles", 0);
		gameCanvas.gameObject.SetActive(true);
		overCanvas.gameObject.SetActive(false);
		EndCanvas.gameObject.SetActive(false);

	}

	void Update()
	{
		if (trs.score >= 5 && trs.score <= 20) {
			waittime = Random.Range (1.4f, 1.7f);
		}
		if (trs.score >= 21 && trs.score <= 40) {
			waittime = Random.Range (1.1f, 1.4f);
		}
		if (trs.score >= 41) {
			waittime = Random.Range (.8f, 1.1f);
		}

		if (player.isalive == false) {
			gameCanvas.gameObject.SetActive(false);
			if (trs.score < 150) {
				overCanvas.gameObject.SetActive(true);
			}
			trs.EndScore ();
			trs.SetHighScore ();
			player.Move (0);
		}
		if (trs.score == 150) {
			EndCanvas.gameObject.SetActive (true);
			player.isalive = false;
			player.lives = -1;
			PlayerPrefs.SetInt("Coincount", PlayerPrefs.GetInt("Coincount")+200);
		}
	}
		
	public void SpawnObstacles()
	{
		GameObject zap = Instantiate (obstacles [Random.Range (0, obstacles.Length)]);
		if (player.isalive == false) {
			CancelInvoke ("SpawnObstacles");
		}
		StartCoroutine (ReDoObstacle ());
	}


	public void SceneToChangeTo(string scene)
	{
		SceneManager.LoadScene (scene);
	}

	IEnumerator ReDoObstacle()
	{
		yield return new WaitForSecondsRealtime (waittime);
		SpawnObstacles ();
	}
}
