using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject MenuRetry;

    // Start is called before the first frame update
    void Start()
    {
        MostrarMenuRetry();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MostrarMenuRetry()
    {
        MenuRetry.SetActive(true);
    }
}
