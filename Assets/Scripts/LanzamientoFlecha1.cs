using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>
public class LanzamientoFlecha1 : MonoBehaviour
{
    public GameObject flecha;
    public float fuerza;
    public static LanzamientoFlecha1 instance;
    public GameObject arco;
    void Start()
    {
        
    }

    public static LanzamientoFlecha1 Singleton
    {
        get
        {
            if (instance == null)
            {
                instance = new LanzamientoFlecha1();
            }
            return instance;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        GameObject Arcozeta = Instantiate(flecha, transform.position, transform.rotation);
        Arcozeta.GetComponent<Rigidbody2D>().velocity = transform.right * fuerza;
    }

    private void FixedUpdate()
    {
        GameObject b = Pool.singleton.Get("Flecha");
        //Si la referencia está llena
        if (b != null)
        {
            //Le aplico a la bala la misma posición que la nave
            b.transform.position = this.transform.position;
            //Activamos la bala en concreto
            b.SetActive(true);
        }
    }
}
