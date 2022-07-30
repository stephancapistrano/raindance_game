using UnityEngine;
using System.Collections;

public class AbreMenuFinal : MonoBehaviour {
    float timer1;
    public Transform menuzin;
    int cont;
    // Use this for initialization
    void Start () {
        cont = 1;
	}
	
	// Update is called once per frame
	void Update () {
        if (Colisor.vitoria==1 && cont == 1) {
            timer1 += Time.deltaTime;
            if (timer1>=3) {
                Instantiate(menuzin, transform.position, transform.rotation);
                cont = 0;
            }
        }

        if (Colisor.derrota == 1 && cont == 1) {
            timer1 += Time.deltaTime;
            if (timer1 >= 3) {
                Instantiate(menuzin, transform.position, transform.rotation);
                cont = 0;
            }
        }
    }
}
