using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Script creado para conseguir el movimiento del arco, es decir, para que el arco siga la posición del ratón y rote orientado a él.
/// </summary>
public class ArcoScript : MonoBehaviour
{
    public Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector2 flechaPos = transform.position;

        direction = MousePos - flechaPos;

        FaceMouse();
    }

    public void FaceMouse()
    {
        transform.right = direction;
    }
}
