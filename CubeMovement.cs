using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    [SerializeField] private float speed = 1.5f;
    private Transform transform;
    void Start()
    {
        transform = GetComponent<Transform>();   
    }

    // MODIFICACIÓN: Se ha añadido la función para detectar colisiones, si es una cápsula, se aumenta la velocidad.
    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Capsule") {
            speed *= 2;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Mover con Translate.
        if (Input.GetKey("up")) {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        } else if (Input.GetKey("down")) {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        } else if (Input.GetKey("left")) {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        } else if (Input.GetKey("right")) {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }
}
