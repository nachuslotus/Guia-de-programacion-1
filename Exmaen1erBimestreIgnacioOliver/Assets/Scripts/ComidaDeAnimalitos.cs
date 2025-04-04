using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComidaDeAnimalitos : MonoBehaviour
{

    public string codigo;
    public int cantidaddedias;
    int GramoscComidaTotal;
    int racionGatos = 300;
    int racionPerrosPequeños = 400;
    int racionPerrosGrandes = 700;
    int RacionAnimalActual;
    float CostoAlimento;
    float precioPorGramos = 80;


     

    


   

    // Start is called before the first frame update
    void Start()
    {
        
        

        if (codigo == "G" || codigo=="g")
        {
            RacionAnimalActual = racionGatos;

        }
        
        else if (codigo == "PP" || codigo == "pp")
        {
            RacionAnimalActual = racionPerrosPequeños;
        }

        else if (codigo == "PG" || codigo == "pg")
        {
            RacionAnimalActual = racionPerrosGrandes;

        }

        GramoscComidaTotal = RacionAnimalActual * cantidaddedias;
        CostoAlimento = GramoscComidaTotal / 100 * precioPorGramos;

        Debug.Log("Para este periodo se necesitan " + GramoscComidaTotal + " gramos del alimento");

        Debug.Log("Tenes que pagar " + CostoAlimento );

        if(cantidaddedias < 3)
        {
            Debug.Log("No podemosrealizar esto, debido a que debe ingresar una cnatidad mayor a 3 días");
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
