using UnityEngine;
using System.Collections;

public class TrocaDeCena : MonoBehaviour {

    public void ParaMenu() {
        Application.LoadLevel("Menu");
    }
    public void ParaJogar() {
        Application.LoadLevel("Cena1");
    }
    public void ParaQuit() {
        Application.Quit();
    }

}