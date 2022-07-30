using UnityEngine;
using System.Collections;

public class BotaoE : MonoBehaviour {
    public static float btnE;
    // Use this for initialization
    void Start() {
        btnE = 0;
    }

    // Update is called once per frame
    void Update () {
        if (btnE == 1) {
            transform.position = new Vector3(transform.position.x + 0.75f, transform.position.y, transform.position.z);
            btnE = 0;
        }

        if (Colisor.vitoria==1) {
            transform.position = new Vector3(2.35f, 2.52f, 2.24f);
        }
    }
}
