using UnityEngine;
using UnityEngine.InputSystem; // Importante añadir esta línea

public class Lanzador : MonoBehaviour
{
    public float forceAmount = 500f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Detecta si se ha pulsado la X en este frame con el nuevo sistema
        if (Keyboard.current != null && Keyboard.current.xKey.wasPressedThisFrame)
        {
            rb.AddForce(Vector3.forward * forceAmount);
        }
    }
}