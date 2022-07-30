using UnityEngine;
using System.Collections;

public class JuntaNuvem : MonoBehaviour {
    public static int jntNuvem;
    public static int jntNuvem2;
    void Start() {
        jntNuvem = 0;
        jntNuvem2 = 0;
    }
	// Use this for initialization
	public void Junta () {
        jntNuvem = 1;
        jntNuvem2 = 1;
    }
}
