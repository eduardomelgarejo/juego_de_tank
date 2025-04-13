using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionCamara : MonoBehaviour
{
    public float sensibilidadRaton = 80f;
    public Transform cuerpoJugador;

    private float rotacionX = 0f;


    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }


    void Update()
    {
        float movimientoRatonX = Input.GetAxis("Mouse X") * sensibilidadRaton * Time.deltaTime;

        rotacionX = Mathf.Clamp(rotacionX, -90f, 90f);

        transform.localRotation = Quaternion.Euler(rotacionX, 0f, 0f);
        cuerpoJugador.Rotate(Vector3.up * movimientoRatonX);
    }

}
