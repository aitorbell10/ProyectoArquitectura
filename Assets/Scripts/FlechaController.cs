using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlechaController : MonoBehaviour
{
    public GameObject flechaa;
    public GameObject Enemigo;

    //Este apartado funciona igual que el enemie controller pero lo tiene la flecha para sumar puntuacion al score cuando ocurra lo mismo.
    public void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Enemigo"))
        {
            ScoreScript.scoreValue += 1;
            Destroy(this.gameObject);
            Destroy(collision.gameObject);

        }
    }
}
