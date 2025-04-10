using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heladeria : MonoBehaviour
{
    public string gusto;
    public int gramos;

    float Descuento = 0.1f;
    int PrecioPorKilo = 500;
    int MinimoDegGramos = 250;
    int MaximoDegGramos = 500;

    // Start is called before the first frame update
    void Start()
    {

        if(gusto != "CHO" && gusto != "FRU" && gusto != "DDL"){
            Debug.Log("Debes ingresar un codigo valido (CHO, FRU, DDL).");
            return;
        }
        if( gramos < MinimoDegGramos || gramos > MaximoDegGramos ){
            Debug.Log("Debes pedir como minimo 250 gramos y como maximo 3000.");
            return;
        }

        float precioPorGramo = (PrecioPorKilo / 1000f);
        float precioFinal = precioPorGramo * gramos;
        if(gusto == "FRU"){
            precioFinal = precioFinal * (1 - Descuento);
        }

        Debug.Log("Por el gusto: " + gusto + " deberas abonar: " + precioFinal);
    }

}
