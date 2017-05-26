using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splosions : MonoBehaviour {

	public GameObject Zombie;
	public PlayerHealth dead;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Zombie") {
			other.SendMessage ("Shreaded");

			}
		}


	}

