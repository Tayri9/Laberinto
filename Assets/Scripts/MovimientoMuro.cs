using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoMuro : MonoBehaviour
{
    [SerializeField]
    Vector3 posicionA;

    [SerializeField]
    Vector3 posicionB;

    bool posIni = true;
    bool posFin = false;

    Vector3 posicionMuro;

    [SerializeField]
    float velocidad = 9f;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        posicionMuro = gameObject.GetComponent<Transform>().position;
        
        if(posIni == true)
        {
            transform.Translate(0.1f * Time.deltaTime * velocidad, 0.0f, 0.0f);

            if (posicionB.z >= posicionMuro.z)
            {
                posIni = false;
                posFin = true;
            }
        }
        else if (posFin == true)
        {
            transform.Translate(-0.1f * Time.deltaTime * velocidad, 0.0f, 0.0f);
            
            if(posicionA.z <= posicionMuro.z)
            {
                posIni = true;
                posFin = false;
            }
        }       

        //Debug.Log("Muro: " + posicionMuro + "   A: " + posicionA + "   B: " + posicionB + "   posIni:" + posIni + "   Z: " + posicionMuro.z);

        //3.3, 2.4
        //-0.6, -1.4
    }
    
}
