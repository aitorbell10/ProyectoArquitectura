using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Script creado conseguir la parábola que crea la flecha al ser disparada y caer al suelo.
/// </summary>
public class FlechaScript : MonoBehaviour
{
    Rigidbody2D rb;

    private bool hasHit = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hasHit == false)
        {
            TrackMovement();
        }
    }

    public void TrackMovement()
    {
        Vector2 direcction = rb.velocity;

        float angle = Mathf.Atan2(direcction.y, direcction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            ScoreScript.scoreValue += 1;
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }
        hasHit = true;
        rb.velocity = Vector2.zero;
        rb.isKinematic = true;
        Destroy(this.gameObject, 1f);
    }
}
