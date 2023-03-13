using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiectionBala : MonoBehaviour
{
    public GameObject player;
    public GameObject arco;
    public GameObject navi;

    void Update()
    {
        arco.transform.LookAt(-navi.transform.position);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Grid"))
        {
            Destroy(this.gameObject);
        }
    }

}
