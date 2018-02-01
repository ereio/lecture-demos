using UnityEngine;
using System.Collections;

public class AudioController : MonoBehaviour {


	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Space)){
			//audio.Play();

			AudioSource audio = GetComponent<AudioSource>();
			audio.Play();
		}

	}
}
