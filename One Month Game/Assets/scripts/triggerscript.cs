using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class triggerscript : MonoBehaviour {

	public int score;
	private playerscript player;

	public Text scoretext;

	public Text endScoreText;

	public Text HighScoreText;

	public Text endscoretext2;

	public Text highscoretext2;

	public AudioSource scoresound;

	void Start () {
		player = FindObjectOfType<playerscript> ();
	}

	void Update()
	{
		scoretext.text = "Score: " + score;
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if(player.isalive == true)
		{
			if (other.CompareTag ("Respawn")) {
				score = score + 1;
				scoresound.Play ();
			}
		}
	}

	public void EndScore()
	{
		endScoreText.text = "Score: " + score;
		endscoretext2.text = "Score: " + score;
	}

	public void SetHighScore()
	{
	    if (PlayerPrefs.GetInt ("Highscore") < score) {
				PlayerPrefs.SetInt ("Highscore", score);
			}

		HighScoreText.text = "Highscore: " + PlayerPrefs.GetInt ("Highscore");
		highscoretext2.text = "Highscore: " + PlayerPrefs.GetInt ("Highscore");
	}
}
