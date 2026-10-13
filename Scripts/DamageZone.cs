using UnityEngine;

public class DamageZone : MonoBehaviour
{
    public int danioRecibido = 0;

    void OnTriggerEnter(Collider other)
    {
        danioRecibido += 10;
        Debug.Log("Daño actual: " + danioRecibido);
    }
}