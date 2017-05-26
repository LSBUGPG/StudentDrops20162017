using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ZedSpawner : MonoBehaviour {

	public GameObject Zombie;
	public float spawntime = 2f;
	public Text announcer;


	void Start () {

		InvokeRepeating ("zedspawn", spawntime, spawntime);
		announcer.text = ("Survive for as long as you can!");
		Invoke ("Clear", 3);



	}
	
	// Update is called once per frame
	void Update () {


	


	
	}
		
	void zedspawn (){
		
		
		Instantiate (Zombie, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
	}
	void Clear () {
		announcer.text = ("");
}
}
