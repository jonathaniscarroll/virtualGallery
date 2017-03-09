using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextLevel : MonoBehaviour {

	public GameObject next;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerExit(Collider other){
		Instantiate (next, other.transform.position - new Vector3 (-1f, 250f, 6f), Quaternion.Euler(-90,0,0));
		Destroy (gameObject,5);
	}
}
