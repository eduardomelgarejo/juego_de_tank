using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    public Transform puntoDisparo;
    public GameObject bala;

    public float fuerzaDisparo = 1500f;
    public float intervaloDisparo = 0.3f;

    private float tiempoProximoDisparo = 0;


    void Start()
    {

    }


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (Time.time > tiempoProximoDisparo)
            {
                GameObject nuevaBala;
                nuevaBala = Instantiate(bala, puntoDisparo.position, puntoDisparo.rotation);

                nuevaBala.GetComponent<Rigidbody>().AddForce(puntoDisparo.forward * fuerzaDisparo);

                tiempoProximoDisparo = Time.time + intervaloDisparo;

                Destroy(nuevaBala, 5);
            }
        }

    }

}
