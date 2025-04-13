using UnityEngine;
using System.Collections;

public class EnemigoColision : MonoBehaviour
{
    private int colisionCount = 0;
    private int disparosNecesarios;
    private Tanques.Dificultad dificultadSeleccionada;

    public static int puntuacion = 0;
    private static bool puntuacionMostrada = false;

    void Start()
    {
        if (!puntuacionMostrada)
        {
            Debug.Log("Última puntuación: " + puntuacion);
            puntuacionMostrada = true;
        }

        StartCoroutine(MostrarPuntuacionPeriodicamente());

        GameObject parent = transform.parent.gameObject;
        Tanques tanquesScript = parent.GetComponent<Tanques>();

        if (tanquesScript != null)
        {
            dificultadSeleccionada = tanquesScript.dificultadSeleccionada;
        }

        switch (dificultadSeleccionada)
        {
            case Tanques.Dificultad.Facil:
                disparosNecesarios = 1;
                break;
            case Tanques.Dificultad.Medio:
                disparosNecesarios = 2;
                break;
            case Tanques.Dificultad.Dificil:
                disparosNecesarios = 3;
                break;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            colisionCount++; 

            if (colisionCount >= disparosNecesarios)
            {
                puntuacion++; 
                Destroy(gameObject);
            }
        }
    }

    private IEnumerator MostrarPuntuacionPeriodicamente()
    {
        while (true)
        {
            yield return new WaitForSeconds(3f);
            Debug.Log("Puntuación actual: " + puntuacion);
        }
    }
}
