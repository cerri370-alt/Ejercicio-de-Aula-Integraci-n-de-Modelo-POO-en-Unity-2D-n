
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class GuerreroMovimiento : MonoBehaviour
{
    [SerializeField] private float velocidad = 5f;

    private Rigidbody2D rb;
    private Vector2 movimiento;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        movimiento = Vector2.zero;

        if (UnityEngine.InputSystem.Keyboard.current == null)
            return;

        if (UnityEngine.InputSystem.Keyboard.current.wKey.isPressed || UnityEngine.InputSystem.Keyboard.current.upArrowKey.isPressed)
        {
            movimiento.y = 1f;
        }
           

        if (UnityEngine.InputSystem.Keyboard.current.sKey.isPressed || UnityEngine.InputSystem.Keyboard.current.downArrowKey.isPressed)
        {
            movimiento.y = -1f;
        }
            

        if (UnityEngine.InputSystem.Keyboard.current.aKey.isPressed || UnityEngine.InputSystem.Keyboard.current.leftArrowKey.isPressed)
        {
            movimiento.x = -1f;
        }
            

        if (UnityEngine.InputSystem.Keyboard.current.dKey.isPressed || UnityEngine.InputSystem.Keyboard.current.rightArrowKey.isPressed)
        {
            movimiento.x = 1f;
        }
            

        movimiento = movimiento.normalized;
    }


    private void FixedUpdate()
    {
        GuerreroControlador controlador =
            GetComponent<GuerreroControlador>();

        if (controlador != null && !controlador.EstaVivo)
        {
            rb.linearVelocity = Vector2.zero;
            return;
        }

        rb.linearVelocity = movimiento * velocidad;
    }

}

