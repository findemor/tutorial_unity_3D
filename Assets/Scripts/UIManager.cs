using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TMPro.TextMeshProUGUI UITextBolos;
    public TMPro.TextMeshProUGUI UITextReloj;
    public TMPro.TextMeshProUGUI UITextPuntuacion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActualizarTextoBolos(int bolos)
    {
        UITextBolos.text = bolos.ToString();
    }

    public void ActualizarTextoPuntuacion(int puntuacion)
    {
        UITextPuntuacion.text = puntuacion.ToString();
    }

    public void ActualizarTextoReloj(float tiempoTranscurrido)
    {
        

        int minutos = (int)(tiempoTranscurrido / 60);
        int segundos = (int)(tiempoTranscurrido % 60);

        string textoAmostrar = string.Format("{0:00}:{1:00}", minutos, segundos);

        UITextReloj.text = textoAmostrar;
    }
}
