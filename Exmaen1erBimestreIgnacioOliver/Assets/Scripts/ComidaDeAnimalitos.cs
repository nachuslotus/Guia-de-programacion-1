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
        
        if (cantidaddedias < 3)
        {
            Debug.Log("Cantidad de días no valida");
            return;
        }

        
            if (codigo == "G" || codigo == "g")
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

            Debug.Log("Tenes que pagar " + CostoAlimento);
        else
        {
            Debug.Log("Hay un error de coigo no valido");
            return;
        }






    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
