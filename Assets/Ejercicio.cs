using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio : MonoBehaviour {

    public string producto1 = "";
    public string producto2 = "";
    public string producto3 = "";
    public int precio1 = 0;
    public int precio2 = 0;
    public int precio3 = 0;
    public int unidades1 = 0;
    public int unidades2 = 0;
    public int unidades3 = 0;

    // Use this for initialization
    void Start () {
        int descuento1 = precio1 / 5;
        int descuento2 = precio2 / 5;
        int descuento3 = precio3 / 5;
        int montoFinal = precio1 + precio2 + precio3;
        int montoDescuento1 = montoFinal - descuento1;
        int montoDescuento2 = montoFinal - descuento2;
        int montoDescuento3 = montoFinal - descuento3;
        int descuentos = descuento1 + descuento2 + descuento3;
        int montoDescuentos = montoFinal - descuentos;

        if (precio1 < 1 || precio2 < 1 || precio3 < 1)
        {
            Debug.Log("Error");
        } else if(unidades1 < 1 || unidades2 < 1 || unidades3 < 1)
        {
            Debug.Log("Error");
        }
        else if (unidades1 > 3 && unidades2 > 3 && unidades3 > 3)
        {
            Debug.Log("El monto total de la compra es igual a: '" + montoFinal + "' con descuento de : '" + descuentos + "' y el monto con descuento es: " + montoDescuentos);
        }
        else if(unidades1 > 3)
        {
            Debug.Log("El monto total de la compra es igual a: '"+montoFinal+"' con descuento de : '"+descuento1+"' y el monto con descuento es: " + montoDescuento1);
        }else if( unidades2 > 3)
        {
            Debug.Log("El monto total de la compra es igual a: '" + montoFinal + "' con descuento de : '" + descuento2 + "' y el monto con descuento es: " + montoDescuento2);
        } else if( unidades3 > 3)
        {
            Debug.Log("El monto total de la compra es igual a: '" + montoFinal + "' con descuento de : '" + descuento3 + "' y el monto con descuento es: " + montoDescuento3);
        } 
        else
        {
            Debug.Log("El monto total de la compra es igual a: " + montoFinal + " no hay descuentos");
        }


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
