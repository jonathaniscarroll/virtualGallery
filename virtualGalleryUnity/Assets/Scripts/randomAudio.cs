using UnityEngine;
using System.Collections;

public class randomAudio : MonoBehaviour {

	private AudioClip audio;
	public AudioClip[] audioList;

	private int audioLen;
	private AudioSource source;

	// Use this for initialization
	void Start () {

		audioLen = audioList.Length;
		audio = audioList [Random.Range (0,audioLen)];
		source = GetComponent<AudioSource> ();
		source.clip = audio;
//		source.pitch = Random.Range (-3f, 3f);
//		source.volume = Random.Range (0.1f, 1f);
		source.time = Random.Range(0,350);
		source.Play ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
