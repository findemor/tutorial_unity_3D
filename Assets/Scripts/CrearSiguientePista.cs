using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearSiguientePista : MonoBehaviour
{
    public GameObject PrefabPista;

    public Transform PistaPadre;
    private Vector3 SiguientePosicion;


    // Start is called before the first frame update
    void Start()
    {
        SiguientePosicion = new Vector3(PistaPadre.position.x - PistaPadre.localScale.x, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Jugador")
        {
            Debug.Log("Jugador ha entrado en el trigger");
            PistaPadre.GetComponent<MoverPista>().Detener();
            Instantiate(PrefabPista, SiguientePosicion, Quaternion.identity);
        }
    }

}
