using UnityEngine;
using System.Collections;

public class ColisorPontos : MonoBehaviour {
    public static float a;
    public static float b;

    void OnTriggerEnter(Collider other) {
        //R
        if (other.CompareTag("Finish")) {
            if (JuntaNuvem.jntNuvem==1) {
                BotaoD.btnD = 1;
                BotaoE.btnE = 1;
                JuntaNuvem.jntNuvem = 0;
            }
            if (JuntaNuvem.jntNuvem2 == 1) {
                BotaoD.btnD = 1;
                BotaoE.btnE = 1;
                JuntaNuvem.jntNuvem2 = 0;
            }
        }
        //L
        if (other.CompareTag("Respawn")) {
            if (JuntaNuvem.jntNuvem == 1) {
                BotaoD.btnD = 1;
                BotaoE.btnE = 1;
                JuntaNuvem.jntNuvem = 0;
            }
            if (JuntaNuvem.jntNuvem2 == 1) {
                BotaoD.btnD = 1;
                BotaoE.btnE = 1;
                JuntaNuvem.jntNuvem2 = 0;
            }
        }
    }
}
