using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using UnityEngine.UI;


public class Grenade : MonoBehaviour {

	public float speed = 3f;
	public GameObject prefab;
	public UnityEvent Oncrash;
	public Text Deathtext;
	public GameObject player;



	// Use this for initialization
	void Start () {



	}

	// Update is called once per frame
	void Update () {

		transform.position += transform.forward * speed * Time.deltaTime;

	}
	void OnCollisionEnter(Collision Col)
	{
		Oncrash.Invoke ();
		Invoke ("Killme", 1);

	}

	public void Killme () {

		Destroy (gameObject);


	}


	}


	