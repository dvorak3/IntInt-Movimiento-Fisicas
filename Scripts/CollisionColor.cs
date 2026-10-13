using UnityEngine;

public class CollisionColor : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("He colisionado con: " + collision.gameObject.name);
        // Cambia el color a uno aleatorio al chocar
        GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
    }
}