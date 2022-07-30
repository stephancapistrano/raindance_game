using UnityEngine;
using System.Collections;

public class Colisor : MonoBehaviour {
    public static float vitoria;
    public static float derrota;
    void Start() {
        vitoria = 0;
        derrota = 0;
    }
    void OnTriggerEnter(Collider col) {

        if (col.gameObject.tag == "Finish") {
            //Ganhou
            vitoria = 1;
        }
        if (col.gameObject.tag == "Respawn") {
            //Perdeu
            derrota = 1;
        }
    }
}
