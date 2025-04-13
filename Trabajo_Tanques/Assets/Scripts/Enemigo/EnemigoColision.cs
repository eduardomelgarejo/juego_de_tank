using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoColision : MonoBehaviour
{
    private int colisionCount = 0;  // Contador de colisiones

    private void OnCollisionEnter(Collision collision)
    {
        // Si el objeto que colisiona tiene el tag "Jugador" (puedes cambiar esto si lo necesitas)
        if (collision.gameObject.CompareTag("Player"))
        {
            colisionCount++;

            // Si colisiona exactamente 2 veces
            if (colisionCount == 2)
            {
                Destroy(gameObject);  // Destruye el enemigo
            }
        }
    }
}
