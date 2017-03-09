using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class selectSlides : MonoBehaviour {

	public Texture slide;
	
	// Update is called once per frame
	void Update () {
		if (slide != null && GetComponent<Renderer> ().sharedMaterial.mainTexture != slide) {
			Material mat = new Material("Unlit/Texture");
			GetComponent<Renderer> ().sharedMaterial.mainTexture = slide;
		}
	}
}
