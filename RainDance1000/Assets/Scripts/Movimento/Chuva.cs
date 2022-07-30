using UnityEngine;
using System.Collections;

public class Chuva : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(-Time.deltaTime*3,-Time.deltaTime*6,0);

        if (transform.position.y <= -7) {
            Destroy(gameObject);
        }
	}
}
