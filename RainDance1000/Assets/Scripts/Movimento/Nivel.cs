using UnityEngine;
using System.Collections;

public class Nivel : MonoBehaviour {
    float time3;
    public static int  nivell;
	// Use this for initialization
	void Start () {
        time3 = 0; nivell = 0;
    }
	
	// Update is called once per frame
	void Update () {
        time3 += Time.deltaTime;
        if (time3 < 7) {
            nivell = 1;
        } else if (time3 >= 7) {
            nivell = 2;
        } else if (time3 >= 15) {
            nivell = 3;
        } else if (time3 >= 25) {
            nivell = 4;
        } else if (time3 >= 40) {
            nivell = 5;
        }
    }
}
