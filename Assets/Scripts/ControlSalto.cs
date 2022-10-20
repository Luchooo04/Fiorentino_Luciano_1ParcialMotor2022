using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ControlSalto : MonoBehaviour
{
    private Rigidbody rb;
    public float saltoVel;
    private bool enElSuelo = true;
    public int maxSaltos = 4;
    public int saltoActual = 0;

    
    private void Start()
    {

        rb = GetComponent<Rigidbody>();


    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && (enElSuelo || maxSaltos > saltoActual))
        {
            rb.velocity = new Vector3(0f, saltoVel, 0f * Time.deltaTime);
            //rigidBody.AddForce(Vector3.up * saltoVel, ForceMode.Impulse);
            enElSuelo = false;
            saltoActual++;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        enElSuelo = true;
        saltoActual = 0;
    }

}
