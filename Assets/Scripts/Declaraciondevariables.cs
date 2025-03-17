using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Declaraciondevariables : MonoBehaviour
{

    int tubos_pringles = 40;
    string marca = "Pringles";
    bool es_lays = false;
    float media_de_papas = 43.5f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(tubos_pringles);
        Debug.Log(marca);
        Debug.Log(es_lays);
        Debug.Log(media_de_papas);
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}
