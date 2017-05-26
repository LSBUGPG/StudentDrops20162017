using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public float speed = 3f;
	public GameObject Zombie;
	public ZombieHealth Hitzombie;
	public GameObject prefab;

	// Use this for initialization
	void Start () {

	
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.position += transform.forward * speed * Time.deltaTime;
	
	}
	void OnCollisionEnter(Collision Col) 
	{
		Destroy (gameObject);
}
	void OnTriggerEnter(Collider other)
	{
		Destroy (gameObject);
		if (other.tag == "Zombie") {
			other.SendMessage("Onhit");
		}

	} 

	}
	
