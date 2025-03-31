using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnConsolaSinIngreso : MonoBehaviour
{

    public int num1;
    public int num2;
    public int num3;
    public int num4;
    public int resultado;
    public int resultado2;

    // Start is called before the first frame update
    void Start()
    {
        num2 = 2;
        resultado = num1 + num2;
        resultado2 = num2*num2 ;
        Debug.Log("el resultado de la primera operacion, es 2. Y la multiplicacion de si mismo es " + resultado2 );

        num3 =4;
        num4 =5;

        Debug.Log(num3+num4);
        Debug.Log(num3 * num4);




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
