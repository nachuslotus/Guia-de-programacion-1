using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conversordemonedas : MonoBehaviour
{

    //Declaracion de variables//

    public float montoAConvertir;
    public string codigoMoneda;

    float cotizacionDolar = 1350.12f;
    float cotizacionEuro = 1622.24f;
    float cotizacionReal = 221.34f;


    float montoConvertido;
    float montoMinimo = 1000;

    float cotizacionMonedaElegida;

    // Start is called before the first frame update
    void Start()
    {
        //ingreso y validacion de datos

        if(montoAConvertir < montoMinimo)
        {
            Debug.Log("el monto minimo es $1000");
            return;
        }

        if(codigoMoneda == "D" || codigoMoneda== "d")
        {
            cotizacionMonedaElegida = cotizacionDolar;
        }
        else if (codigoMoneda == "E" || codigoMoneda == "e")
        {
            cotizacionMonedaElegida = cotizacionEuro;
        }
        else if (codigoMoneda == "R" || codigoMoneda == "r")
        {
            cotizacionMonedaElegida = cotizacionReal;
        }
        else
        {
            Debug.Log("Opcion de moneda extanejra no valida");
            return;
        }



        //Procesamiento datos

        montoConvertido = montoAConvertir / cotizacionMonedaElegida;

        //Salida

        Debug.Log("el monto ingresado equivale a " + montoConvertido);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
