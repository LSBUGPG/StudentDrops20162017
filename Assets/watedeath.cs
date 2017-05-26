using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class watedeath : MonoBehaviour {

	public Image waterscreenfiller;
	public DeathTimer DeadText;
	public Text watertext;
	public GameObject Player;
	public Transform Mourge;


	// Use this for initialization
	void Start () {
		GameObject.FindGameObjectsWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter (Collider other)
	{
		if (other.name == "Player") {
			waterscreenfiller.gameObject.SetActive (true);
			DeadText.SendMessage ("displaytime");
			watertext.text = ("Don't feed the zombie sharks!");
			Invoke ("reset", 3);
			Debug.Log ("You are wet");
			Player.transform.position = Mourge.position;
		}
	}
	void reset (){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		}
	}
