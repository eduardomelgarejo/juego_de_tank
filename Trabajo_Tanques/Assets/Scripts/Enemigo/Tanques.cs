using UnityEngine;

public class Tanques : MonoBehaviour
{
    public enum Dificultad
    {
        Facil = 1,
        Medio = 2,
        Dificil = 3
    }

    [Header("Configuración de dificultad")]
    public Dificultad dificultadSeleccionada = Dificultad.Facil;  // Configuración de la dificultad
}
