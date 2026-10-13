using UnityEngine;

public class MovimientoSinFisicas : MonoBehaviour
{
    public Transform cilindroDestino;
    public Transform cuboObstaculo;
    public float velocidad = 2f;
    public float distanciaColision = 1.5f;
    private bool haTocadoCubo = false;

    void Update()
    {
        // Mueve la esfera hacia el cilindro
        transform.position = Vector3.MoveTowards(transform.position, cilindroDestino.position, velocidad * Time.deltaTime);

        // Comprueba la distancia con el cubo para simular colisión sin Rigidbody
        if (!haTocadoCubo && Vector3.Distance(transform.position, cuboObstaculo.position) < distanciaColision)
        {
            haTocadoCubo = true;
            cuboObstaculo.GetComponent<Renderer>().material.color = Color.blue;
            Debug.Log("Cubo alcanzado, cambiando material");
        }
    }
}