
using UnityEngine;

public class ZonaCuracion : MonoBehaviour
{
    [SerializeField] private int cantidadCuracion = 15;

    private void OnTriggerEnter2D(Collider2D otro)
    {
        GuerreroControlador controlador =
            otro.GetComponentInParent<GuerreroControlador>();

        if (controlador != null)
        {
            controlador.Curar(cantidadCuracion);
        }
    }
}
