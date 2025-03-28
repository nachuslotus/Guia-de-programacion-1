using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnConsolaSinIngreso : MonoBehaviour
{

    public int Num1;
    public int Num2;
    public int resultado;
    public int resultado2;

    // Start is called before the first frame update
    void Start()
    {
        Num2 = 2;
        resultado = Num1 + Num2;
        resultado2 = Num2*Num2 ;
        Debug.Log("el resultado de la primera operacion, es 2. Y la multiplicacion de si mismo es " + resultado2 );

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
