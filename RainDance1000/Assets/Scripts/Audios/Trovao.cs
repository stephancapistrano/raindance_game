using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]

public class Trovao : MonoBehaviour {

    AudioSource audio;

    void Start() {
        audio = GetComponent<AudioSource>();
        audio.pitch = 1;
    }
	
	// Update is called once per frame
	void Update () {
	    if(BotaoD.trovao == 1) {
            audio.Play();
        }
	}
}
