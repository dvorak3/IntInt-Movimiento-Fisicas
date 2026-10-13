using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    private Color originalColor;

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Renderer>() != null)
        {
            originalColor = other.GetComponent<Renderer>().material.color;
            other.GetComponent<Renderer>().material.color = Color.red; // Color al entrar
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Renderer>() != null)
        {
            other.GetComponent<Renderer>().material.color = originalColor; // Restaura al salir
        }
    }
}