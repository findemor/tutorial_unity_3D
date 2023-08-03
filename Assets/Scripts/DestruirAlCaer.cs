using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirAlCaer : MonoBehaviour
{
    public float DestruirSiYMenor = -1f;
    GameController GC;

    public bool EsJugador = false;

    // Start is called before the first frame update
    void Start()
    {
        GC = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < DestruirSiYMenor)
        {
            if (EsJugador)
            {
                //GameOver
                GC.GameOver();
            } else
            {
                GC.ContarBoloTirado();
            }

            GameObject.Destroy(gameObject);
        }
    }
}
