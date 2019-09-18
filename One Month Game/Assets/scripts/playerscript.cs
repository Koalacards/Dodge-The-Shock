using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class playerscript : MonoBehaviour {

	private Rigidbody2D rb2d;

	public bool isalive;

	Vector2 minimum;

	Vector2 maximum;

	public GameObject coinobject;

	public int coincount;

	public int coinscollected;

	public Text cointext;

	public AudioSource coinpickup;

	public AudioSource hitElec;

	bool hasplayed;

	public int lives;
	public Text taptext;

	void Start () {
		rb2d = FindObjectOfType<Rigidbody2D> ();
		isalive = true;
		Invoke ("SpawnCoin", 0);
		hasplayed = false;
		if (0 == PlayerPrefs.GetInt ("Sprite")) {
			lives = 1;
			transform.position = new Vector2 (0, -3.14f);
			transform.localScale = new Vector2 (2, 2);
		}
		if (1 == PlayerPrefs.GetInt ("Sprite")) {
			lives = 1;
			transform.position = new Vector2 (0, -3.14f);
			transform.localScale = new Vector2 (2, 2);
		}
		if (2 == PlayerPrefs.GetInt ("Sprite")) {
			lives = 1;
			transform.position = new Vector2 (0, -3.225f);
			transform.localScale = new Vector2 (1.5f, 1.5f);
		}
		if (3 == PlayerPrefs.GetInt ("Sprite")) {
			lives = 2;
			transform.position = new Vector2 (0, -3.14f);
			transform.localScale = new Vector2 (2, 2);
		}
		this.gameObject.SetActive (true);
		taptext.text = "tap anywhere on the\n     screen to move";
		Invoke ("removetaptext", 10f);
			
	}
	void Update()
	{
		cointext.text = "Coins: " + coincount;
		if (lives <= 0) {
			if (!hasplayed) {
				hitElec.Play ();
				hasplayed = true;
			}
			isalive = false;
			this.gameObject.SetActive (false);
			CancelInvoke ("SpawnCoin");
		}
	}


	public void Move(float moveint)
	{
		rb2d.velocity = new Vector2 (moveint, 0);
	}

	public void rotate (float rot)
	{
		transform.rotation = Quaternion.Euler(0, rot,0);
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag ("Respawn")) {
			lives = lives - 1;
			Debug.Log ("Hit an object");
			if (isalive == true) {
				hitElec.Play ();
			}
		}

		if(other.CompareTag("coin"))
			{
			other.gameObject.SetActive (false);
			coincount = coincount + 1;
			coinpickup.Play ();
			PlayerPrefs.SetInt("Coincount", PlayerPrefs.GetInt("Coincount")+1);
			Invoke ("SpawnCoin", 2);
			}

		if (other.CompareTag ("leftside")) {
			transform.position = new Vector2 (2.46f, -3.14f);
			rotate (180);
		}
		if (other.CompareTag ("rightside")) {
			transform.position = new Vector2 (-2.46f, -3.14f);
			rotate (0);
		}
	}


	public void SpawnCoin()
	{
		GameObject coin = Instantiate (coinobject);
		coin.transform.position = new Vector2 (Random.Range(-2.8f, 2.8f), -3.14f);
	}
		
	public void removetaptext()
	{
		taptext.text = "";
	}
}