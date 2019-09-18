using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class storeeconomy : MonoBehaviour {

	public Text button1;
	public Text button2;
	public Text button3;
	public Text button4;
	public Text errortext;
	void Start () {
		
		if (0 == PlayerPrefs.GetInt("Sprite")) {
			button1.text = "Equipped";
		} 
		else {
			button1.text = "Equip";
		}
		if ( 1 == PlayerPrefs.GetInt("Sprite")) {
			button2.text = "Equipped";
		} 
		else if (PlayerPrefs.GetInt("Button2") ==1 ) {
			button2.text = "Equip";
		} 
		else {
			button2.text = "Cost: 50";
		}
		if (2 == PlayerPrefs.GetInt("Sprite")) {
			button3.text = "Equipped";
		} 
		else if (PlayerPrefs.GetInt("Button3") ==1) {
			button3.text = "Equip";
		} 
		else {
			button3.text = "Cost: 100";
		}
		if (3 == PlayerPrefs.GetInt("Sprite")) {
			button4.text = "Equipped";
		} 
		else if (PlayerPrefs.GetInt("Button4") ==1) {
			button4.text = "Equip";
		} 
		else {
			button4.text = "Cost: 150";
		}
		errortext.text = "";
	}

	public void Buy2()
	{
		if (50 <= PlayerPrefs.GetInt ("Coincount") && PlayerPrefs.GetInt("Button2") ==0) {
			PlayerPrefs.SetInt ("Coincount", PlayerPrefs.GetInt ("Coincount") - 50);
			PlayerPrefs.SetInt ("Button2", 1);
			hit2 ();
		} 
		if (50 > PlayerPrefs.GetInt ("Coincount") && PlayerPrefs.GetInt("Button2") ==0) {
			errortext.text = "not enough coins";
			Invoke ("Errorstop", 3f);
		}
		if (PlayerPrefs.GetInt("Button2") ==1) {
			hit2 ();
		}
	}

	public void Buy3()
	{
		if (100 <= PlayerPrefs.GetInt ("Coincount") && PlayerPrefs.GetInt("Button3") ==0)
		{
			PlayerPrefs.SetInt("Coincount", PlayerPrefs.GetInt("Coincount") - 100);
			PlayerPrefs.SetInt ("Button3", 1);
			hit3 ();
		}
		if (100 > PlayerPrefs.GetInt ("Coincount") && PlayerPrefs.GetInt("Button3") ==0) {
			errortext.text = "not enough coins";
			Invoke ("Errorstop", 3f);
		}
		if (PlayerPrefs.GetInt("Button3") ==1) {
			hit3 ();
		}

	}

	public void Buy4()
	{
		if(150 <= PlayerPrefs.GetInt("Coincount") && PlayerPrefs.GetInt("Button4") ==0)
		{
			PlayerPrefs.SetInt("Coincount", PlayerPrefs.GetInt("Coincount") - 150);
			PlayerPrefs.SetInt ("Button4", 1);
			hit4 ();
		}
		if (150 > PlayerPrefs.GetInt ("Coincount") && PlayerPrefs.GetInt("Button4") ==0) { 
			errortext.text = "not enough coins";
			Invoke ("Errorstop", 3f);
		}
		if (PlayerPrefs.GetInt("Button4") ==1) {
			hit4 ();
		}
	}


	public void hit1()
	{
		button1.text = "Equipped";
		if (PlayerPrefs.GetInt("Button2") ==1 ) {
			button2.text = "Equip";
		} 
		else {
			button2.text = "Cost: 50";
		}
		if (PlayerPrefs.GetInt("Button3") ==1 ) {
			button3.text = "Equip";
		} 
		else {
			button3.text = "Cost: 100";
		}
		if (PlayerPrefs.GetInt("Button4") ==1 ) {
			button4.text = "Equip";
		} 
		else {
			button4.text = "Cost: 150";
		}
		PlayerPrefs.SetInt ("Sprite", 0);
	}

	public void hit2()
	{
			button2.text = "Equipped";
			button1.text = "Equip";
		if (PlayerPrefs.GetInt("Button3") ==1 ) {
				button3.text = "Equip";
			} else {
			button3.text = "Cost: 100";
			}
		if (PlayerPrefs.GetInt("Button4") ==1 ) {
				button4.text = "Equip";
			} else {
			button4.text = "Cost: 150";
			}
		PlayerPrefs.SetInt ("Sprite", 1);
	}

	public void hit3()
	{
			button3.text = "Equipped";
			button1.text = "Equip";
		if (PlayerPrefs.GetInt("Button2") ==1 ) {
				button2.text = "Equip";
			} 
		else {
			button2.text = "Cost: 50";
			}
		if (PlayerPrefs.GetInt("Button4") ==1 ) {
				button4.text = "Equip";
			} 
		else {
			button4.text = "Cost: 150";
			}
		PlayerPrefs.SetInt ("Sprite", 2);

	}
	public void hit4()
	{
			button4.text = "Equipped";
			button1.text = "Equip";
		if (PlayerPrefs.GetInt("Button3") ==1 ) {
				button3.text = "Equip";
			} 
		else {
			button3.text = "Cost: 100";
			}
		if (PlayerPrefs.GetInt("Button2") ==1 ) {
				button2.text = "Equip";
			} 
		else {
			button2.text = "Cost: 50";
			}
		PlayerPrefs.SetInt ("Sprite", 3);
	}

	public void Errorstop()
	{
		errortext.text = "";
	}
}
