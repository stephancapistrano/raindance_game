using UnityEngine;
using System.Collections;

public class IndioMov : MonoBehaviour {
    float ran;
    float time1,time2;

    void Start () {
        time1 = 0;
        time2 = 0;
        ran = Random.Range(-0.0005f,0.0005f);
	}
	
	void Update () {
        if (Colisor.derrota == 1) {
            transform.Translate(Time.deltaTime*Random.Range(-2,2),0,0);
        } else {
            //nivel danca
            if (Nivel.nivell == 1) {
                time1 += Time.deltaTime + ran;
            } else if (Nivel.nivell == 2) {
                time1 += Time.deltaTime + ran * 2;
            } else if (Nivel.nivell == 3) {
                time1 += Time.deltaTime + ran * 3;
            } else if (Nivel.nivell == 4) {
                time1 += Time.deltaTime + ran * 4;
            } else if (Nivel.nivell == 5) {
                time1 += Time.deltaTime + ran * 5;
            }
            //danca indio
            if (time1 >= time2) {
                time2 += 1;
            }
            if (time2 % 2 == 0) {
                transform.localScale = new Vector3(-1, transform.localScale.y, transform.localScale.z);
            } else {
                transform.localScale = new Vector3(1, transform.localScale.y, transform.localScale.z);
            }
        }

        
    }
}
