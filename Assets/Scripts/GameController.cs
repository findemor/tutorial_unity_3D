using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject MenuRetry;

    private int PuntuacionActual = 0;
    private int BolosTirados = 0;
    private float TiempoInicial = 0f;
    private bool EstaCorriendo = false;

    public UIManager UI;

    private float tiempoTranscurrido = 0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (EstaCorriendo)
        {
            tiempoTranscurrido = Time.time - TiempoInicial;

            UI.ActualizarTextoReloj(tiempoTranscurrido);
        }
    }

    public void ContarBoloTirado()
    {
        BolosTirados = BolosTirados + 1;

        UI.ActualizarTextoBolos(BolosTirados);

        CalcularPuntuacion();
    }

    public void Empezar()
    {
        if (!EstaCorriendo)
        {
            EstaCorriendo = true;
            TiempoInicial = Time.time;
        }
    }

    public void CalcularPuntuacion()
    {
        
        if (tiempoTranscurrido <= 0)
        {
            PuntuacionActual = 0;
        } else
        {
            PuntuacionActual = (int)(BolosTirados * 1000 / tiempoTranscurrido);
        }

        UI.ActualizarTextoPuntuacion(PuntuacionActual);
    }

    public void MostrarMenuRetry()
    {
        MenuRetry.SetActive(true);
    }

    public void GameOver()
    {
        EstaCorriendo = false;

        MostrarMenuRetry();
    }
}
