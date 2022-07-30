using UnityEngine;
using System.Collections;

public class Teste : MonoBehaviour {

    void Update() {
        if (Colisor.vitoria == 1) {
            Destroy(gameObject);
        }
        if (Colisor.derrota == 1) {
            Destroy(gameObject);
        }
    }
}
