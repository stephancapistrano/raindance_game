using UnityEngine;
using System.Collections;

public class BotaoD : MonoBehaviour {
    public static float btnD;
    public static float trovao;
    // Use this for initialization
    void Start() {
        btnD = 0;
    }

    // Update is called once per frame
    void Update() {
        if (btnD == 1) {
            transform.position = new Vector3(transform.position.x - 0.75f, transform.position.y, transform.position.z);
            trovao = 1;
            btnD = 0;
            
        }



        if (Colisor.vitoria == 1) {
            transform.position = new Vector3(2.11f, 3.0f, 2.24f);
        }
    }
}
