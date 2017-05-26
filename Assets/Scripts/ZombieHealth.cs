using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ZombieHealth : MonoBehaviour {

	public GameObject Bullets;
	public int Zedhealth = 3;
	public int Zombcount = 0;
	public PlayerHealth progression;

	// Use this for initialization
	void Start () {

	Zedhealth = 3;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Zedhealth <= 0) {
			Destroy (gameObject);
			Zombcount += 1;
			progression.SendMessage ("Addzomb");
		}
	}
	public void Onhit () {

		Zedhealth -= 1;
	}
	public void Shreaded () {
		Zedhealth -= 3;
	}

}
