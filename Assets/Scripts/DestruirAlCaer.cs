using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirAlCaer : MonoBehaviour
{
    public float DestruirSiYMenor = -1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < DestruirSiYMenor)
        {
            GameObject.Destroy(gameObject);
        }
    }
}
