using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathTimer : MonoBehaviour {

	public int second;
	public int minute;
	public int hour;
	public Text HRtext;
	public Text Mtext;
	public Text Stext;

	// Use this for initialization
	void Start () {
		
		InvokeRepeating ("Second", 0, 1);
	}
	
	// Update is called once per frame
	void Update () {
		if (second == 60) {
			minute += 1;
			second = 0;
		}
		if (minute >= 60) {
			hour += 1;
			minute = 0;
		}

	}
	void Second (){
		second += 1;

	} 
	void displaytime (){
		HRtext.text = hour.ToString ();
		Mtext.text = minute.ToString ();
		Stext.text = second.ToString ();
	}
}
