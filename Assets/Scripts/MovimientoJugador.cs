using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    public Transform FuerzaDirecta;
    public Transform FuerzaIzquierda;
    public Transform FuerzaDerecha;

    public float PotenciaDirecta = 10f;
    public float PotenciaLateral = 10f;

    private Rigidbody CuerpoJugador;

    // Start is called before the first frame update
    void Start()
    {
        CuerpoJugador = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S)) //Patada directa
        {
            CuerpoJugador.AddForce(FuerzaDirecta.right * PotenciaDirecta, ForceMode.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.D)) //Patada lateral izquierda, va hacia la derecha
        {
            CuerpoJugador.AddForce(FuerzaIzquierda.right * PotenciaLateral, ForceMode.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.A)) //Patada lateral derecha, va hacia la izquierda
        {
            CuerpoJugador.AddForce(FuerzaDerecha.right * PotenciaLateral, ForceMode.Impulse);
        }

    }
}
