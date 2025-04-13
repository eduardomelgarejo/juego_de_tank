using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    public CharacterController controladorPersonaje;
    public float velocidad = 12f;

    void Update()
    {
        float entradaX = Input.GetAxis("Horizontal");
        float entradaZ = Input.GetAxis("Vertical");

        // Calcular la dirección de movimiento solo en X y Z
        Vector3 direccionMovimiento = transform.right * entradaX + transform.forward * entradaZ;
        direccionMovimiento *= velocidad * Time.deltaTime;

        // Aquí viene la clave: mantener la altura constante sin tocar transform.position
        // Vamos a mover al personaje manualmente solo en X y Z
        Vector3 nuevaPosicion = controladorPersonaje.transform.position + direccionMovimiento;
        nuevaPosicion.y = 0.96f;

        controladorPersonaje.enabled = false; // Desactivamos el CharacterController temporalmente
        controladorPersonaje.transform.position = nuevaPosicion; // Asignamos la nueva posición con Y fija
        controladorPersonaje.enabled = true; // Lo volvemos a activar
    }
}
