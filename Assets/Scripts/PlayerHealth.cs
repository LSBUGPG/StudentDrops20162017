using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {

	public GameObject Zed;
	public Transform Mourge;
	public Image DeathImage;
	public DeathTimer Death;
	public int zombiekill;
	public Text ZEDEADCOUNTER;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other) {
		if (other.tag == "Zombie") {
			DeathImage.gameObject.SetActive (true);
			transform.position = Mourge.position;
			Invoke ("Reset", 2);
			Death.SendMessage ("displaytime", 1);
			Invoke ("BrownBread", 0);
		}
	}
		public void Reset(){

		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);


	}
	public void Addzomb() {
		zombiekill += 1;
	}
	public void BrownBread(){
		ZEDEADCOUNTER.text = zombiekill.ToString ();
	}
}
