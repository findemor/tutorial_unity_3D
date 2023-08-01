using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirPistasAnteriores : MonoBehaviour
{
    public Transform PosicionJugador;
    public float DistanciaMaxima = 40f;

    // Start is called before the first frame update
    void Start()
    {
        PosicionJugador = GameObject.Find("Jugador").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PosicionJugador != null)
        {
            if (Vector3.Distance(gameObject.transform.position, PosicionJugador.position) > DistanciaMaxima)
            {
                GameObject.Destroy(gameObject);
            }
        }
    }
}
