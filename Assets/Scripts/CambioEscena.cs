﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    public void cambiarescena (string nombredeescena)
    {
        SceneManager.LoadScene(1);
    }
    public void cambiarescena2 (string nombredeescena2)
    {
        SceneManager.LoadScene(0);
    }
}
