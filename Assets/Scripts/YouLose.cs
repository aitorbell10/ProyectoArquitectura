using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouLose : MonoBehaviour
{
    public GameObject suelo;
    public GameObject flecha;
    private int vidas = 3;

    // Update is called once per frame
    void Update()
    {
        if (vidas == 0)
        {
            ScoreScript.scoreValue = 0;
            SceneManager.LoadScene(2);
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        vidas -= 1;
    }
}
