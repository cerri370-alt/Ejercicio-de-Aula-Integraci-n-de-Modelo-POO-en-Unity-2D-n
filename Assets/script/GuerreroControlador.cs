
using UnityEngine;
using UnityEngine.InputSystem;

public class GuerreroControlador : MonoBehaviour
{
    private GuerreroLogico guerrero;


    public bool EstaVivo
    {
        get { return guerrero != null && guerrero.EstaVivo; }
    }


    [Header("Atributos del guerrero")]
    [SerializeField] private string nombre = "Guerrero";
    [SerializeField] private int vidaMax = 100;
    [SerializeField] private int escudoInicial = 25;

    private void Awake()
    {
        guerrero = new GuerreroLogico(nombre, vidaMax, escudoInicial);
    }

    private void Update()
    {

        

        if (Keyboard.current == null)
            return;

        

        if (Keyboard.current.hKey.wasPressedThisFrame)
        {
            guerrero.RecibirDanio(20);
            MostrarEstado();
        }

        if (Keyboard.current.jKey.wasPressedThisFrame)
        {
            guerrero.Curar(15);
            MostrarEstado();
        }
    }

    private void MostrarEstado()
    {
        Debug.Log(
            guerrero.Nombre +
            " | Vida: " + guerrero.VidaActual +
            " | Escudo: " + guerrero.Escudo +
            " | Vivo: " + guerrero.EstaVivo
        );
    }


    public void RecibirDanio(int cantidad)
    {
        if (guerrero == null)
            return;

        guerrero.RecibirDanio(cantidad);
        MostrarEstado();
    }


    public void Curar(int cantidad)
    {
        if (guerrero == null)
            return;

        guerrero.Curar(cantidad);
        MostrarEstado();
    }


}
