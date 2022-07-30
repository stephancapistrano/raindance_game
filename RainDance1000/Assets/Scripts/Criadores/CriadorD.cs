using UnityEngine;
using System.Collections;

public class CriadorD : MonoBehaviour {

    public Transform l;
    public Transform r;
    float timer4;
    // Use this for initialization
    void Start() {
        Invoke("InvokeL", 2);
        Invoke("InvokeR", 4);
    }

    // Update is called once per frame
    void Update () {
        if (Colisor.vitoria == 1) {
            Destroy(gameObject);
        }
    }
    void InvokeL() {
        Instantiate(l, transform.position, transform.rotation);
        Invoke("InvokeL", Random.Range(2.0f, 7.0f));
    }
    void InvokeR() {
        Instantiate(r, transform.position, transform.rotation);
        Invoke("InvokeR", Random.Range(2.0f, 7.0f));
    }
}
