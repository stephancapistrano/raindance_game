using UnityEngine;
using System.Collections;

public class CriaChuva : MonoBehaviour {
    public Transform chuvinha;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(Random.Range(-8.0f, 14.0f), transform.position.y, transform.position.z);
        if (Colisor.vitoria==1) {
            Instantiate(chuvinha, transform.position, transform.rotation);
        }
        
    }
}
