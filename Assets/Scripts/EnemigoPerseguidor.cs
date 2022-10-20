using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemigoPerseguidor : MonoBehaviour
{
    private int hp;
    private GameObject jugador;
    public int rapidez;
    public Transform Player;
    int MoveSpeed = 4;
    int MaxDist = 2;
    int MinDist = 1;




    void Start()
    {
        hp = 100;
        //Otra forma de obtener un GameObject sin arrastrarlo desde el editor
        jugador = GameObject.Find("Jugador");

    }

    void Update()
    {
        transform.LookAt(jugador.transform);
        transform.Translate(rapidez * Vector3.forward * Time.deltaTime);
        transform.LookAt(Player);

        if (Vector3.Distance(transform.position, Player.position) >= MinDist)
        {

            transform.position += transform.forward * MoveSpeed * Time.deltaTime;



            if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
            {

            }

        }
    }
    public void recibirDaño()
    {
        hp = hp - 25;

        if (hp <= 0)
        {
            this.desaparecer();
        }
    }

    private void desaparecer()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bala"))
        {
            recibirDaño();
        }
    }

}