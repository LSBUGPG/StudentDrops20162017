using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NadeLauncher : MonoBehaviour {


	public GameObject Prefab;

	Itemcontroller fire;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {



	}

	public void Onfire(){
		GameObject Grenade = Instantiate (Prefab, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity) as GameObject;
		Rigidbody rb = Grenade.GetComponent<Rigidbody> ();
		rb.velocity = Camera.main.transform.forward * 40;
	}
}
