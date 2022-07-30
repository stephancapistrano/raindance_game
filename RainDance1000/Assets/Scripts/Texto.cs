using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Texto : MonoBehaviour {
    Text text;
    // Use this for initialization
    void Start () {
        text = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Colisor.vitoria == 1) {
            text.text = "Congratulations, you realized the ritual!";
        } else if (Colisor.derrota == 1) {
            text.text = "You do not know how to dance!";
        }
    }
}
