using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    public CharacterController controladorPersonaje;
    public float velocidad = 12f;

    public Transform groundCheck;
    public float radioEsfera = 0.3f;
    public LayerMask mascaraSuelo;
    private bool estaEnSuelo;

    void Update()
    {
        Chequear_suelo();

        float entradaX = Input.GetAxis("Horizontal");
        float entradaZ = Input.GetAxis("Vertical");

        Vector3 direccionMovimiento = transform.right * entradaX + transform.forward * entradaZ;

        controladorPersonaje.Move(direccionMovimiento * velocidad * Time.deltaTime);

        
        if (estaEnSuelo)
        {
            Vector3 posicionCorregida = controladorPersonaje.transform.position;
            posicionCorregida.y = 0.96f;
            controladorPersonaje.transform.position = posicionCorregida;
        }
    }

    void Chequear_suelo()
    {
        estaEnSuelo = Physics.CheckSphere(groundCheck.position, radioEsfera, mascaraSuelo);
    }
}
