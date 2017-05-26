using UnityEngine;
using System.Collections;

public class bulletdestruct : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollsionEnter(Collision Col) 
	{
		Destroy (gameObject);
	}
}
