using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlJugador : MonoBehaviour
{

    
    private Rigidbody rb;
    public float rapidezDesplazamiento = 10.0f;
    private int cont;
    public TMPro.TMP_Text textoCantidadRecolectados;
    public TMPro.TMP_Text textoGanaste;
    public GameObject powerup;
    public CapsuleCollider col;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        col = GetComponent<CapsuleCollider>();
        cont = 0;
        textoGanaste.text = "";
        setearTextos();

    }
    private void setearTextos()
    {
        textoCantidadRecolectados.text = " Dolares Totales: " + cont.ToString();
        if (cont >= 6)
        {
            textoGanaste.text = " Ganaste!!! ";
        }

    }


    void Update()
    {
        float movimientoAdelanteAtras = Input.GetAxis("Vertical") * rapidezDesplazamiento;
        float movimientoCostados = Input.GetAxis("Horizontal") * rapidezDesplazamiento;

        movimientoAdelanteAtras *= Time.deltaTime;
        movimientoCostados *= Time.deltaTime;

        transform.Translate(movimientoCostados, 0, movimientoAdelanteAtras);

        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
        }

        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PowerUp") == true)
        {

            rapidezDesplazamiento = rapidezDesplazamiento + 5;
            rb.transform.localScale *=3; 
            cont= cont + 1;
           
            other.gameObject.SetActive(false);
        }
       
        
         if (other.gameObject.CompareTag("Coleccionable") == true)
         {
                
            other.gameObject.SetActive(false);
            cont = cont + 1;
            setearTextos();
         }
        
    }



    

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "powerup")
        {
            Debug.Log("Collision detected");
            powerup.GetComponent<Renderer>().enabled = false;
        }
    }

    public void Recolocar()
    {
        transform.position= Vector3.zero;
    }
}

