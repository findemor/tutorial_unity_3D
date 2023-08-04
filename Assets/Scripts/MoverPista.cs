using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPista : MonoBehaviour
{
    private bool Mover;
    private Vector3 PosicionInicial;
    public float Velocidad = 0.2f;
    public int DistanciaMaxima = 3;

    public GameObject SpacebarSprite;
    public ParticleSystem PSDetener;


    // Start is called before the first frame update
    void Start()
    {
        if (Velocidad > 0f)
        {
            Mover = true;
        } else
        {
            Mover = false;
        }

        PosicionInicial = transform.position;
        SpacebarSprite.SetActive(true);

    }

    public void Detener()
    {
        if (Mover)
        {
            Mover = false;
            SpacebarSprite.SetActive(false);
            PSDetener.Play();
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (Mover)
        {

            float distanciaActual = Vector3.Distance(transform.position, PosicionInicial);
            if (distanciaActual >= DistanciaMaxima)
            {
                Velocidad = Velocidad * -1;
            }

            //movemos
            transform.position = transform.position + Vector3.forward * Velocidad * Time.deltaTime;

            if (Mover && Input.GetKeyDown(KeyCode.Space))
            {
                Detener();
                Mover = false;
            }

        }
    }
}
