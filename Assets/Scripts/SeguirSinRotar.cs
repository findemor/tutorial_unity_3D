using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirSinRotar : MonoBehaviour
{
    public GameObject Jugador;
    private Vector3 distancia;


    // Start is called before the first frame update
    void Start()
    {
        distancia = transform.position - Jugador.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        transform.position = Jugador.transform.position + distancia;
    }
}
