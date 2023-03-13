using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class freeze : MonoBehaviour
{
    private Transform arcoz;

    // Start is called before the first frame update
    void Start()
    {
        arcoz = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        arcoz.SetPositionAndRotation(this.transform.position,Quaternion.identity);
    }
}
