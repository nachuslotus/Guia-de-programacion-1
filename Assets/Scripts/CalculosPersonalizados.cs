using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculosPersonalizados : MonoBehaviour
{


    public float Num1;
    public float Num2;
    public float Resultado;
    // Start is called before the first frame update
    void Start()
    {
        Resultado = Num1 + Num2 ;

        Debug.Log(" El resultado de la suma entre " + Num1 + " y " + Num2 + " es:" + Resultado );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
