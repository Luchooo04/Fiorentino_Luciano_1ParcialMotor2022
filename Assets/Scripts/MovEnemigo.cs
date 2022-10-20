using UnityEngine;

public class MovEnemigo: MonoBehaviour
{

    bool tengoQueBajar = false;
    int rapidez = 25;

    void Update()
    {
        if (transform.position.y >= 8)
        {
            tengoQueBajar = true;
        }
        if (transform.position.y <= 2)
        {
            tengoQueBajar = false;
        }

        if (tengoQueBajar)
        {
            Bajar();
        }
        else
        {
            Subir();
        }

    }

    void Subir()
    {
        transform.position += transform.up * rapidez * Time.deltaTime;
    }

    void Bajar()
    {
        transform.position -= transform.up * rapidez * Time.deltaTime;
    }
}