using UnityEngine;
using System.Collections;

public class NuvemE : MonoBehaviour {

    float vel;
    // Use this for initialization
    void Start() {
        vel = 0;
    }
    // Update is called once per frame
    void Update () {
        if (Nivel.nivell == 1) {
            vel = 0.1f;
        } else if (Nivel.nivell == 2) {
            vel = 0.5f;
        } else if (Nivel.nivell == 3) {
            vel = 1f;
        } else if (Nivel.nivell == 4) {
            vel = 2;
        } else if (Nivel.nivell == 5) {
            vel = 2.5f;
        }

        transform.Translate(-vel * Time.deltaTime, 0, 0);
    }
}
