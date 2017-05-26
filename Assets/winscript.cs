using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class winscript : MonoBehaviour {

	public Image WinImage;
	public Text Wintext;
	public Transform mourge;
	public GameObject Player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}  
	void OntriggerEnter (Collider other){
		if (other.name == "Player") {
			if (other.name == "Player") {
				WinImage.gameObject.SetActive (true);
				Wintext.text = ("You win!");
				Invoke ("reset", 3);
				Debug.Log ("You are wet");
				Player.transform.position = mourge.position;
				Invoke ("reset", 3);
			

		}

	}
}
	void reset (){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
}
	
