using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Itemcontroller : MonoBehaviour {

	public Transform[] Items;
	public bool Gotrifle = false;
	public bool Gotshotgun = false;
	public bool Gotlauncher = false;
	public int Bullets = 30;
	public int grenades = 6;
	public int CurrentItem;
	public AR shoot;
	public Text Guntext;
	public Text bulletText;
	public Text ShellText;
	public Text Grenadetext;
	public int burstcontroller = 0;
	public int Shells = 6;
	public shotgun Attack;
	public NadeLauncher Obliterate;
	public int Firedelay = 0;


	// Use this for initialization
	void Start () {

		Guntext.text = "Unarmed";
		changeItem (0);
		bulletText.text = "";
		ShellText.text = "";
	}

	// Update is called once per frame
	void Update () {

		Firedelay -= 1;

		if (Firedelay <= 0) {
			Firedelay = 0;
		}

		burstcontroller -= 0;

		if (burstcontroller < 0) {
			burstcontroller = 0;
		}

		Invoke ("Fire", 0);
		Invoke ("Blast", 0);
		Invoke ("Explode", 0);


		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			changeItem (0);
			Guntext.text = "Unarmed";
		} else if (Input.GetKeyDown (KeyCode.Alpha2)) {
			if (Gotrifle == true) {
				changeItem (1);
				Guntext.text = "R23 A2";
			}
		} else if (Input.GetKeyDown (KeyCode.Alpha3)) {
			if (Gotshotgun == true) {
				changeItem (2);
				Guntext.text = "BlueHawk M1903";
			}
		} else if (Input.GetKeyDown (KeyCode.Alpha4)) {
			if (Gotlauncher == true) {
				changeItem (3);
				Guntext.text = "BV43 Utility rifle";
			}
		}
		}
	void OnTriggerEnter (Collider other) {
		
		if (other.gameObject.CompareTag ("Shotgun")) {
			other.gameObject.SetActive (false);
			Gotshotgun = true;
			ShellText.text = Shells.ToString ();
		}
		if (other.gameObject.CompareTag ("Shellbox")) {
			other.gameObject.SetActive (false);
			Shells += 6;
			ShellText.text = Shells.ToString ();
		}

		if (other.gameObject.CompareTag ("Gun")) {
			other.gameObject.SetActive (false);
			Gotrifle = true;
			bulletText.text = Bullets.ToString ();
		}
		if (other.gameObject.CompareTag ("Magazine")) {
			other.gameObject.SetActive (false);
			Bullets += 30;
			bulletText.text = Bullets.ToString ();
		}
		if (other.gameObject.CompareTag ("Launcher")) {
			other.gameObject.SetActive (false);
			grenades += 6;
			Gotlauncher = true;
			Grenadetext.text = grenades.ToString ();
		}
		if (other.gameObject.CompareTag ("Grenade")) {
			other.gameObject.SetActive (false);
			grenades += 1;
			Grenadetext.text = grenades.ToString ();
		}

	}
	public void changeItem (int num){
		CurrentItem = num;
		for (int i = 0; i < 4; i++) {
			if (i == num)
				Items [i].gameObject.SetActive (true);
			else
				Items [i].gameObject.SetActive (false);


		} 
	}
	public void Fire (){

		if ( CurrentItem == 1) {
			if (Bullets >= 1) {
				if (Gotrifle == true) {
					if (Input.GetKeyDown (KeyCode.Mouse0)) {
						shoot.Onfire ();
						Bullets -= 1;
						bulletText.text = Bullets.ToString ();
					}
				}
			}
		
		}

	}
		public void Blast() 
	{
		if ( CurrentItem == 2) {
			if (Shells >= 1) {
				if (Firedelay == 0) {
				if (Gotshotgun == true) {
					if (Input.GetKeyDown (KeyCode.Mouse0)) {
						Attack.Onfire ();
						Firedelay = 100;
						Shells -= 1;
						print ("Firing");
						ShellText.text = Shells.ToString ();

	}

}
			}
		}
	}
	
}
	public void Explode () {
		if (CurrentItem == 3) {
			if (grenades >= 1) {
				if (Firedelay == 0) {
					if (Gotlauncher == true) {
						if (Input.GetKeyDown (KeyCode.Mouse0)) {
							Obliterate.Onfire ();
							Firedelay = 100;
							grenades -= 1;
							print ("Firing");
							Grenadetext.text = grenades.ToString ();
	}
}
				}
			}
		}
	}
}





