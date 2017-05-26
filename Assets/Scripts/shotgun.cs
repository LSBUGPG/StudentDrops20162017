using UnityEngine;
using System.Collections;

public class shotgun : MonoBehaviour {

	public GameObject Prefab;

	Itemcontroller fire;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Onfire(){
		
		GameObject ShotgunShell = Instantiate (Prefab, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity) as GameObject;
		Rigidbody rb = ShotgunShell.GetComponent<Rigidbody> ();
		rb.velocity = Camera.main.transform.forward * 40;
	}
}

