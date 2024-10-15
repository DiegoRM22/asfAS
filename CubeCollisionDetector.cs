using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollisionDetector : MonoBehaviour
{
    // Start is called before the first frame update4
    public int score = 0;

    // MODIFICACION: Se ha añadido la función para detectar colisiones, si es un cubo, se aumenta la puntuación.
    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Cube") {
            score = score +2;
        }
    }
}
