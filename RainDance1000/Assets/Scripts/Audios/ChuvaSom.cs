using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]

public class ChuvaSom : MonoBehaviour {

    AudioSource audio;
    // Use this for initialization
    void Start() {
        audio = GetComponent<AudioSource>();
        audio.pitch = 1;
    }

    // Update is called once per frame
    void Update () {
        if (Colisor.vitoria == 1) {
            audio.Play();
        }
	}
}
