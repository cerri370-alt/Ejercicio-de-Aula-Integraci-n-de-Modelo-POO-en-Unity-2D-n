
using UnityEngine;

public class ZonaDanio : MonoBehaviour
{
    [SerializeField] private int cantidadDanio = 20;

    private void OnTriggerEnter2D(Collider2D otro)
    {
        GuerreroControlador controlador =
            otro.GetComponentInParent<GuerreroControlador>();

        if (controlador != null)
        {
            controlador.RecibirDanio(cantidadDanio);
        }
    }
}
