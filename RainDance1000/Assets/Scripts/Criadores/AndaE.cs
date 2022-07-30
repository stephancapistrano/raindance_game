using UnityEngine;
using System.Collections;

public class AndaE : MonoBehaviour {
    float vel; float timer1;
    // Use this for initialization
    void Start() {
        vel = 0; timer1 = 0;
    }

    // Update is called once per frame
    void Update () {
        if (Nivel.nivell == 1) {
            vel = 1;
        } else if (Nivel.nivell == 2) {
            vel = 1.5f;
        } else if (Nivel.nivell == 3) {
            vel = 2;
        } else if (Nivel.nivell == 4) {
            vel = 2.5f;
        } else if (Nivel.nivell >= 5) {
            vel = 3;
        }
        //timer1 += Time.deltaTime;
        if (transform.position.x<0.1f) {
            Destroy(gameObject);
        }
        transform.Translate(-Time.deltaTime * vel, 0, 0);

        if (Colisor.vitoria == 1) {
            Destroy(gameObject);
        }
    }
}
