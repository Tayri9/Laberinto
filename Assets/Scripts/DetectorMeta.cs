using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DetectorMeta : MonoBehaviour
{
    [SerializeField]
    GameObject pantallaFinal;

    [SerializeField]
    TextMeshProUGUI textLabelTime;

    float tiempoPartida = 0.0f;
    bool estaJugando = true;

    private void Update()
    {
        if (estaJugando == true)
        {
            tiempoPartida = tiempoPartida + Time.deltaTime;
        }        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Jugador llegó a la meta");
            pantallaFinal.SetActive(true);
            //Bloquear jugador para que no se mueva al llegar a la meta
            other.GetComponent<MovimientoJugador>().enabled = false;
            estaJugando = false;
            textLabelTime.text = tiempoPartida.ToString();
        }
    }

    
}
