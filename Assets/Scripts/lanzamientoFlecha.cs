using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class lanzamientoFlecha : MonoBehaviour
{
    public GameObject navi;
    public Camera micamara;
    public GameObject player;
    public float fuerza;
    public GameObject flechaa;
    private float impulse = 200;
    //public static lanzamientoFlecha instance;

    //Singleton
    //private void Awake()
    //{
    //    if (!instance)  
    //    {
    //        instance = this;
    //    }
    //    else
    //    {
    //        Destroy(this.gameObject);
    //        return;
    //    }
    //}

    //public static lanzamientoFlecha Singleton
    //{
    //    get
    //    {
    //        if (instance == null)
    //        {
    //            instance = new lanzamientoFlecha();
    //        }
    //        return instance;
    //    }
    //}

    void Start()
    {
        Rigidbody rb = flechaa.GetComponent<Rigidbody>();
        flechaa.SetActive(false);
    }

    void FixedUpdate()
    {
        if (Input.GetButton("Fire1"))
        {
            navi.SetActive(true);

            RaycastHit hit;
            Ray Ray = micamara.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(Ray, out hit))
            {
                navi.transform.position = hit.point;

            }
            //distancia
            fuerza = Vector2.Distance(navi.transform.position, player.transform.position);
            Debug.Log("Fuerza:" + fuerza);

        }
        else
        {
            navi.SetActive(false);
        }



        if (Input.GetButtonUp("Fire1"))
        {
            //GameObject bullet = Instantiate(flechaa, player.transform.position,player.transform.rotation) as GameObject;
            //bullet.GetComponent<Rigidbody>().AddForce(bullet.transform.forward * fuerza * impulse);
            //flechaa.gameObject.SetActive(true);
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
}
