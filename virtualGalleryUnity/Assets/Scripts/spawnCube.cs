using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnCube : MonoBehaviour {

	public GameObject cube;
	public GameObject player;
	public int Distance;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
			
	}

	void OnTriggerExit(Collider other){
		Vector3 newPos = transform.position + new Vector3 (0,Random.Range(0,1000) + Distance, 0);
		Instantiate (cube, newPos, transform.rotation);
		Destroy (gameObject);
	}
}
