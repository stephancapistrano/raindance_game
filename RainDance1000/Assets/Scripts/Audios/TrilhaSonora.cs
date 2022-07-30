using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]

public class TrilhaSonora : MonoBehaviour {
    AudioSource audio;
    // Use this for initialization
    void Start () {
        audio = GetComponent<AudioSource>();
        audio.pitch = 1;
    }
	
	// Update is called once per frame
	void Update () {
        if (Nivel.nivell == 1) {
            audio.pitch = 1;
        } else if (Nivel.nivell == 2) {
            audio.pitch = 1.1f;
        } else if (Nivel.nivell == 3) {
            audio.pitch = 1.2f;
        } else if (Nivel.nivell == 4) {
            audio.pitch = 1.3f;
        } else if (Nivel.nivell == 5) {
            audio.pitch = 1.5f;
        }

        if (Colisor.vitoria==1) {
            audio.volume -= Time.deltaTime/3;
        }
        if (Colisor.derrota == 1) {
            audio.pitch -= 0.1f;
        }
    }
}
