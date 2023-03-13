using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Script creado para poder moverte entre escenas con el menu y la pantalla final.
/// </summary>
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
