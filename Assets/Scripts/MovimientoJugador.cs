using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    //Variables
    public float movimientoEjeX;
    public float movimientoEjeZ;
    public float movimientoEjeY;
    public float velocidadMovimiento = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movimientoEjeX = - Input.GetAxis("Vertical") * Time.deltaTime * velocidadMovimiento;
        movimientoEjeZ = Input.GetAxis("Horizontal") * Time.deltaTime * velocidadMovimiento;

        transform.Translate(movimientoEjeX, movimientoEjeY, movimientoEjeZ);
    }
}
