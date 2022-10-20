using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System.Threading;

public class ReinicioJuego: MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("r"))
        {
            Time.timeScale = 1; ;
            Restart();
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}