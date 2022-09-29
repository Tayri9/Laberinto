using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ColisionMoneda : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI textLabelMonedas;

    int contadorMoneda = 0;

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Moneda")
        {
            //Desactivo la moneda
            col.gameObject.SetActive(false);

            //Sumo una moneda
            contadorMoneda++;

            //Muestro el contador de monedas en el Label que se activa al llegar a la meta
            textLabelMonedas.text = contadorMoneda.ToString();
        }
    }
}
